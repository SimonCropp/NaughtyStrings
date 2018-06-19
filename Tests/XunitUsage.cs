using System.Collections.Generic;
using System.Diagnostics;
using NaughtyStrings;
using Xunit;

public class XunitUsage
{
    [Theory]
    [MemberData(
        memberName: nameof(NaughtyDataProvider.GetData),
        MemberType = typeof(NaughtyDataProvider))]
    public void Run(string naughtyString)
    {
        Debug.WriteLine(naughtyString);
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