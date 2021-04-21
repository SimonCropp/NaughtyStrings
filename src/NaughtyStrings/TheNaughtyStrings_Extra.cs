using System.Collections.Generic;

namespace NaughtyStrings
#if Bogus
.Bogus
#endif
{
    public static partial class TheNaughtyStrings
    {
        /// <summary>
        /// Special characters that are commonly used by Microsoft Word.
        /// </summary>
        public static IReadOnlyList<string> SpecialWordCharacters = new List<string>
        {
            "En dash –",
            "Em dash —",
            "Horizontal bar ―",
            "Figure dash ‒",
            "Swung dash ⁓",
            "Single opening quote ‘",
            "Single closing quote ’",
            "Double opening quote “",
            "Double closing quote ”",
            "Copyright ©",
            "Registered ®",
            "Trademark ™",
            "Section §",
            "Paragraph ¶",
            "Ellipsis …",
            "Optional hyphen ¬",
            "Non-breaking hyphen " + (char) 2011,
            "Em space " + (char) 2003,
            "En space " + (char) 2002,
            "Quarter space " + (char) 2005
        };
    }
}