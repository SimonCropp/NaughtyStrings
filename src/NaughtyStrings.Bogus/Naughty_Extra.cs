namespace NaughtyStrings.Bogus;

public partial class Naughty
{
    /// <summary>
    ///  Special characters that are commonly used by Microsoft Word
    /// </summary>
    public IEnumerable<string> SpecialWordCharacters(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return SpecialWordCharacters();
        }
    }

    /// <summary>
    ///  Special characters that are commonly used by Microsoft Word
    /// </summary>
    public string SpecialWordCharacters()
    {
        var index = Random.Number(TheNaughtyStrings.SpecialWordCharacters.Count - 1);
        return TheNaughtyStrings.SpecialWordCharacters[index];
    }

}