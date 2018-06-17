using System.Collections.Generic;
using NaughtyStrings;
using Xunit;
using Xunit.Abstractions;

public class XunitUsage
{
    ITestOutputHelper output;

    public XunitUsage(ITestOutputHelper output)
    {
        this.output = output;
    }

    [Theory]
    [MemberData(
        memberName: nameof(NaughtyDataProvider.GetData),
        MemberType = typeof(NaughtyDataProvider))]
    public void Run(string naughtyString)
    {
        output.WriteLine(naughtyString);
    }
}

public class NaughtyDataProvider
{
    public static IEnumerable<object[]> GetData()
    {
        foreach (var naughtyString in TheNaughtyStrings.All)
        {
            yield return new object[] { naughtyString };
        }
    }
}