using System.Diagnostics;
using NaughtyStrings;
using Xunit;

public class XunitUsage
{
    #region xUnitUsage
    [Fact]
    public void Run()
    {
        foreach (var naughtyString in TheNaughtyStrings.All)
        {
            Debug.WriteLine(naughtyString);
        }
    }
    #endregion
}