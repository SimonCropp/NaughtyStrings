using Bogus;
using System.Collections.Generic;

namespace NaughtyStrings.Bogus
{
    public partial class Naughty : DataSet
    {
        /// <summary>
        ///  Special characters that are commonly used by Microsoft Word
        /// </summary>
        public IEnumerable<string> SpecialWordCharacters(int num = 1)
        {
            Guard.AgainstNegative(num, nameof(num));
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
}
