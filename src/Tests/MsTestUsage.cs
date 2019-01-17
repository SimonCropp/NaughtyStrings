using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NaughtyStrings;

[TestClass]
public class MsTestUsage
{
    #region MsTestUsage
    [TestMethod]
    [DynamicData(nameof(GetData))]
    public void Run(string naughtyString)
    {
        Debug.WriteLine(naughtyString);
    }

    static IEnumerable<object[]> GetData()
    {
        return TheNaughtyStrings.All
            .Select(naughty => new object[] {naughty});
    }
    #endregion
}