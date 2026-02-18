public class TestUsage
{
    #region TestUsage

    [Test]
    public void Run()
    {
        foreach (var naughtyString in TheNaughtyStrings.All)
        {
            Debug.WriteLine(naughtyString);
        }
    }

    #endregion
}
