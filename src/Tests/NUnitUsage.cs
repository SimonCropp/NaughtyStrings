using System.Collections;
using System.Diagnostics;
using System.Linq;
using NaughtyStrings;
using NUnit.Framework;

[TestFixture]
public class NUnitUsage
{
    [Test, TestCaseSource(nameof(GetData))]
    public void Run(string naughtyString)
    {
        Debug.WriteLine(naughtyString);
    }

    static IEnumerable GetData
    {
        get => TheNaughtyStrings.All
            .Select(_ => new TestCaseData(_));
    }
}