using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

public class Sync
{
    ITestOutputHelper output;

    public Sync(ITestOutputHelper output)
    {
        this.output = output;
    }

    [Fact]
    public async Task SyncNaughtyStrings()
    {
        var path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "../../../../NaughtyStrings/AllNaughtyStrings.cs"));
        File.Delete(path);
        using (var fileStream = File.Open(path, FileMode.Create))
            using (var writer = new StreamWriter(fileStream, Encoding.Unicode))
        using (var provider = CodeDomProvider.CreateProvider("CSharp"))
        {
            await Inner(writer, provider);
        }
    }

    async Task Inner(StreamWriter writer, CodeDomProvider provider)
    {
        var httpClient = new HttpClient();
        var content = await httpClient.GetStringAsync("https://raw.githubusercontent.com/minimaxir/big-list-of-naughty-strings/master/blns.txt");

        var categories = Parse(content).ToList();
        writer.WriteLine(@"
using System.Collections.Generic;

namespace NaughtyStrings
{
    public static class TheNaughtyStrings
    {");

        var lines = categories.SelectMany(x => x.Lines);
        WriteList(writer, provider, "All", "All naughty strings.", lines);

        writer.WriteLine(@"
    }
}");
    }

    static void WriteList(StreamWriter writer, CodeDomProvider provider, string name,string comment, IEnumerable<string> lines)
    {
        writer.WriteLine($@"

        /// <summary>
        /// {comment}
        /// </summary>
        public static IReadOnlyList<string> {name} = new List<string>
        {{");
        foreach (var line in lines)
        {
            WriteLine(writer, provider, line);
        }
        writer.WriteLine(@"
        };");
    }

    private static void WriteLine(StreamWriter writer, CodeDomProvider provider, string line)
    {
        writer.Write("            ");
        if (line.StartsWith("\t"))
        {
            writer.Write("@");
        }

        provider.GenerateCodeFromExpression(new CodePrimitiveExpression(line), writer, null);
        writer.WriteLine(",");
    }

    IEnumerable<Category> Parse(string content)
    {
        var strings = content.Split(new[]{  "\n\n#\t"}, StringSplitOptions.None);
        foreach (var group in strings)
        {
            var lines = group.Split('\n');
            yield return new Category
            {
                Title = TrimHash(lines[0]),
                Description = string.Concat(lines.Skip(1).TakeWhile(x => x.StartsWith("#")).Select(TrimHash)),
                Lines = lines.Skip(1).Where(x => x.Length > 0 && !x.StartsWith("#")).ToList(),
            };
        }
    }

    static string TrimHash(string s)
    {
        return s.TrimStart('#').Trim();
    }

}