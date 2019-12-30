﻿using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using VerifyXunit;
using Xunit;
using Xunit.Abstractions;

public class Sync:
    VerifyBase
{
    [Fact]
    public async Task SyncNaughtyStrings()
    {
        var httpClient = new HttpClient();
        var content = await httpClient.GetStringAsync("https://raw.githubusercontent.com/minimaxir/big-list-of-naughty-strings/master/blns.txt");

        var categories = Parse(content).ToList();

        var naughtyStringsPath = Path.GetFullPath(Path.Combine(SourceDirectory, "../NaughtyStrings/TheNaughtyStrings.cs"));
        File.Delete(naughtyStringsPath);
        using (var provider = CodeDomProvider.CreateProvider("CSharp"))
        {
            await using var writer = File.CreateText(naughtyStringsPath);
            WriteNaughtyStrings(writer, provider, categories);
        }

        var bogusPath = Path.GetFullPath(Path.Combine(SourceDirectory, "../NaughtyStrings.Bogus/Naughty.cs"));
        File.Delete(bogusPath);
        await using (var writer = File.CreateText(bogusPath))
        {
            WriteBogus(writer, categories);
        }
    }

    static void WriteBogus(StreamWriter writer, List<Category> categories)
    {
        writer.WriteLine(@"using Bogus;
using System.Collections.Generic;

namespace NaughtyStrings.Bogus
{
    public class Naughty : DataSet
    {
        /// <summary>
        /// All naughty strings.
        /// </summary>
        public IEnumerable<string> Strings(int num = 1)
        {
            Guard.AgainstNegative(num, nameof(num));
            for (var i = 0; i < num; i++)
            {
                yield return String();
            }
        }

        /// <summary>
        /// A naughty string.
        /// </summary>
        public string String()
        {
            var index = Random.Number(TheNaughtyStrings.All.Count - 1);
            return TheNaughtyStrings.All[index];
        }");

        foreach (var category in categories)
        {
            WriteBogusItem(writer, category.Title, category.Description);
        }

        writer.WriteLine(@"
    }
}");
    }

    static void WriteBogusItem(StreamWriter writer, string name, string comment)
    {
        writer.WriteLine($@"
        /// <summary>
        /// {comment}
        /// </summary>
        public IEnumerable<string> {name}(int num = 1)
        {{
            Guard.AgainstNegative(num, nameof(num));
            for (var i = 0; i < num; i++)
            {{
                yield return {name}();
            }}
        }}

        /// <summary>
        /// {comment}
        /// </summary>
        public string {name}()
        {{
            var index = Random.Number(TheNaughtyStrings.{name}.Count - 1);
            return TheNaughtyStrings.{name}[index];
        }}");
    }

    static void WriteNaughtyStrings(StreamWriter writer, CodeDomProvider provider, List<Category> categories)
    {
        writer.WriteLine(@"using System.Collections.Generic;

namespace NaughtyStrings
#if Bogus
.Bogus
#endif
{
    public static class TheNaughtyStrings
    {");

        var lines = categories.SelectMany(x => x.Lines);
        WriteList(writer, provider, "All", "All naughty strings.", lines);

        foreach (var category in categories)
        {
            WriteList(writer, provider, category.Title, category.Description, category.Lines);
        }

        writer.WriteLine(@"
    }
}");
    }

    static void WriteList(StreamWriter writer, CodeDomProvider provider, string name, string comment, IEnumerable<string> lines)
    {
        if (!comment.EndsWith("."))
        {
            comment += ".";
        }
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

        writer.WriteLine("        };");
    }

    static void WriteLine(StreamWriter writer, CodeDomProvider provider, string line)
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
        var strings = content.Split(new[] {"\n\n#\t"}, StringSplitOptions.None);
        foreach (var group in strings)
        {
            var lines = group.Split('\n');
            var description = string.Join(" ", lines.Skip(1).TakeWhile(x => x.StartsWith("#")).Select(TrimHash));
            var lineZero = lines[0];
            var title = TrimHash(lineZero)
                .Split(":").First()
                .Replace(" ", "")
                .Replace("/", "")
                .Replace("-", "")
                .Replace(")", "")
                .Replace("(", "");
            yield return new Category
            (
                title: title,
                description: description,
                lines: lines.Skip(1).Where(x => x.Length > 0 && !x.StartsWith("#")).ToList()
            );
        }
    }

    static string TrimHash(string s)
    {
        return s.TrimStart('#').Trim();
    }

    public Sync(ITestOutputHelper output) :
        base(output)
    {
    }
}