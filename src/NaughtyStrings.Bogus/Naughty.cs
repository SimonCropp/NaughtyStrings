using Bogus;

namespace NaughtyStrings.Bogus;

public partial class Naughty : DataSet
{
    /// <summary>
    /// All naughty strings.
    /// </summary>
    public IEnumerable<string> Strings(uint num = 1)
    {
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
    }

    /// <summary>
    ///  Strings which may be used elsewhere in code
    /// </summary>
    public IEnumerable<string> ReservedStrings(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return ReservedStrings();
        }
    }

    /// <summary>
    ///  Strings which may be used elsewhere in code
    /// </summary>
    public string ReservedStrings()
    {
        var index = Random.Number(TheNaughtyStrings.ReservedStrings.Count - 1);
        return TheNaughtyStrings.ReservedStrings[index];
    }

    /// <summary>
    ///  Strings which can be interpreted as numeric
    /// </summary>
    public IEnumerable<string> NumericStrings(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return NumericStrings();
        }
    }

    /// <summary>
    ///  Strings which can be interpreted as numeric
    /// </summary>
    public string NumericStrings()
    {
        var index = Random.Number(TheNaughtyStrings.NumericStrings.Count - 1);
        return TheNaughtyStrings.NumericStrings[index];
    }

    /// <summary>
    ///  ASCII punctuation.  All of these characters may need to be escaped in some contexts.  Divided into three groups based on (US-layout) keyboard position.
    /// </summary>
    public IEnumerable<string> SpecialCharacters(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return SpecialCharacters();
        }
    }

    /// <summary>
    ///  ASCII punctuation.  All of these characters may need to be escaped in some contexts.  Divided into three groups based on (US-layout) keyboard position.
    /// </summary>
    public string SpecialCharacters()
    {
        var index = Random.Number(TheNaughtyStrings.SpecialCharacters.Count - 1);
        return TheNaughtyStrings.SpecialCharacters[index];
    }

    /// <summary>
    ///  Strings which contain common unicode symbols (e.g. smart quotes)
    /// </summary>
    public IEnumerable<string> UnicodeSymbols(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return UnicodeSymbols();
        }
    }

    /// <summary>
    ///  Strings which contain common unicode symbols (e.g. smart quotes)
    /// </summary>
    public string UnicodeSymbols()
    {
        var index = Random.Number(TheNaughtyStrings.UnicodeSymbols.Count - 1);
        return TheNaughtyStrings.UnicodeSymbols[index];
    }

    /// <summary>
    ///  Strings which contain unicode subscripts/superscripts; can cause rendering issues
    /// </summary>
    public IEnumerable<string> UnicodeSubscriptSuperscriptAccents(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return UnicodeSubscriptSuperscriptAccents();
        }
    }

    /// <summary>
    ///  Strings which contain unicode subscripts/superscripts; can cause rendering issues
    /// </summary>
    public string UnicodeSubscriptSuperscriptAccents()
    {
        var index = Random.Number(TheNaughtyStrings.UnicodeSubscriptSuperscriptAccents.Count - 1);
        return TheNaughtyStrings.UnicodeSubscriptSuperscriptAccents[index];
    }

    /// <summary>
    ///  Strings which contain misplaced quotation marks; can cause encoding errors
    /// </summary>
    public IEnumerable<string> QuotationMarks(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return QuotationMarks();
        }
    }

    /// <summary>
    ///  Strings which contain misplaced quotation marks; can cause encoding errors
    /// </summary>
    public string QuotationMarks()
    {
        var index = Random.Number(TheNaughtyStrings.QuotationMarks.Count - 1);
        return TheNaughtyStrings.QuotationMarks[index];
    }

    /// <summary>
    ///  Strings which contain two-byte characters: can cause rendering issues or character-length issues
    /// </summary>
    public IEnumerable<string> TwoByteCharacters(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return TwoByteCharacters();
        }
    }

    /// <summary>
    ///  Strings which contain two-byte characters: can cause rendering issues or character-length issues
    /// </summary>
    public string TwoByteCharacters()
    {
        var index = Random.Number(TheNaughtyStrings.TwoByteCharacters.Count - 1);
        return TheNaughtyStrings.TwoByteCharacters[index];
    }

    /// <summary>
    /// 
    /// </summary>
    public IEnumerable<string> Stringswhichcontaintwobyteletters(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return Stringswhichcontaintwobyteletters();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public string Stringswhichcontaintwobyteletters()
    {
        var index = Random.Number(TheNaughtyStrings.Stringswhichcontaintwobyteletters.Count - 1);
        return TheNaughtyStrings.Stringswhichcontaintwobyteletters[index];
    }

    /// <summary>
    ///  A super string recommended by VMware Inc. Globalization Team: can effectively cause rendering issues or character-length issues to validate product globalization readiness.  表          CJK_UNIFIED_IDEOGRAPHS (U+8868) ポ          KATAKANA LETTER PO (U+30DD) あ          HIRAGANA LETTER A (U+3042) A           LATIN CAPITAL LETTER A (U+0041) 鷗          CJK_UNIFIED_IDEOGRAPHS (U+9DD7) Œ           LATIN SMALL LIGATURE OE (U+0153) é           LATIN SMALL LETTER E WITH ACUTE (U+00E9) Ｂ           FULLWIDTH LATIN CAPITAL LETTER B (U+FF22) 逍          CJK_UNIFIED_IDEOGRAPHS (U+900D) Ü           LATIN SMALL LETTER U WITH DIAERESIS (U+00FC) ß           LATIN SMALL LETTER SHARP S (U+00DF) ª           FEMININE ORDINAL INDICATOR (U+00AA) ą           LATIN SMALL LETTER A WITH OGONEK (U+0105) ñ           LATIN SMALL LETTER N WITH TILDE (U+00F1) 丂          CJK_UNIFIED_IDEOGRAPHS (U+4E02) 㐀          CJK Ideograph Extension A, First (U+3400) 𠀀          CJK Ideograph Extension B, First (U+20000)
    /// </summary>
    public IEnumerable<string> SpecialUnicodeCharactersUnion(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return SpecialUnicodeCharactersUnion();
        }
    }

    /// <summary>
    ///  A super string recommended by VMware Inc. Globalization Team: can effectively cause rendering issues or character-length issues to validate product globalization readiness.  表          CJK_UNIFIED_IDEOGRAPHS (U+8868) ポ          KATAKANA LETTER PO (U+30DD) あ          HIRAGANA LETTER A (U+3042) A           LATIN CAPITAL LETTER A (U+0041) 鷗          CJK_UNIFIED_IDEOGRAPHS (U+9DD7) Œ           LATIN SMALL LIGATURE OE (U+0153) é           LATIN SMALL LETTER E WITH ACUTE (U+00E9) Ｂ           FULLWIDTH LATIN CAPITAL LETTER B (U+FF22) 逍          CJK_UNIFIED_IDEOGRAPHS (U+900D) Ü           LATIN SMALL LETTER U WITH DIAERESIS (U+00FC) ß           LATIN SMALL LETTER SHARP S (U+00DF) ª           FEMININE ORDINAL INDICATOR (U+00AA) ą           LATIN SMALL LETTER A WITH OGONEK (U+0105) ñ           LATIN SMALL LETTER N WITH TILDE (U+00F1) 丂          CJK_UNIFIED_IDEOGRAPHS (U+4E02) 㐀          CJK Ideograph Extension A, First (U+3400) 𠀀          CJK Ideograph Extension B, First (U+20000)
    /// </summary>
    public string SpecialUnicodeCharactersUnion()
    {
        var index = Random.Number(TheNaughtyStrings.SpecialUnicodeCharactersUnion.Count - 1);
        return TheNaughtyStrings.SpecialUnicodeCharactersUnion[index];
    }

    /// <summary>
    ///  Characters which increase in length (2 to 3 bytes) when lowercased Credit: https://twitter.com/jifa/status/625776454479970304
    /// </summary>
    public IEnumerable<string> Changinglengthwhenlowercased(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return Changinglengthwhenlowercased();
        }
    }

    /// <summary>
    ///  Characters which increase in length (2 to 3 bytes) when lowercased Credit: https://twitter.com/jifa/status/625776454479970304
    /// </summary>
    public string Changinglengthwhenlowercased()
    {
        var index = Random.Number(TheNaughtyStrings.Changinglengthwhenlowercased.Count - 1);
        return TheNaughtyStrings.Changinglengthwhenlowercased[index];
    }

    /// <summary>
    ///  Strings which consists of Japanese-style emoticons which are popular on the web
    /// </summary>
    public IEnumerable<string> JapaneseEmoticons(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return JapaneseEmoticons();
        }
    }

    /// <summary>
    ///  Strings which consists of Japanese-style emoticons which are popular on the web
    /// </summary>
    public string JapaneseEmoticons()
    {
        var index = Random.Number(TheNaughtyStrings.JapaneseEmoticons.Count - 1);
        return TheNaughtyStrings.JapaneseEmoticons[index];
    }

    /// <summary>
    ///  Strings which contain Emoji; should be the same behavior as two-byte characters, but not always
    /// </summary>
    public IEnumerable<string> Emoji(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return Emoji();
        }
    }

    /// <summary>
    ///  Strings which contain Emoji; should be the same behavior as two-byte characters, but not always
    /// </summary>
    public string Emoji()
    {
        var index = Random.Number(TheNaughtyStrings.Emoji.Count - 1);
        return TheNaughtyStrings.Emoji[index];
    }

    /// <summary>
    ///  Strings which contain unicode numbers; if the code is localized, it should see the input as numeric
    /// </summary>
    public IEnumerable<string> UnicodeNumbers(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return UnicodeNumbers();
        }
    }

    /// <summary>
    ///  Strings which contain unicode numbers; if the code is localized, it should see the input as numeric
    /// </summary>
    public string UnicodeNumbers()
    {
        var index = Random.Number(TheNaughtyStrings.UnicodeNumbers.Count - 1);
        return TheNaughtyStrings.UnicodeNumbers[index];
    }

    /// <summary>
    ///  Strings which contain text that should be rendered RTL if possible (e.g. Arabic, Hebrew)
    /// </summary>
    public IEnumerable<string> RightToLeftStrings(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return RightToLeftStrings();
        }
    }

    /// <summary>
    ///  Strings which contain text that should be rendered RTL if possible (e.g. Arabic, Hebrew)
    /// </summary>
    public string RightToLeftStrings()
    {
        var index = Random.Number(TheNaughtyStrings.RightToLeftStrings.Count - 1);
        return TheNaughtyStrings.RightToLeftStrings[index];
    }

    /// <summary>
    ///  The only unicode alphabet to use a space which isn't empty but should still act like a space.
    /// </summary>
    public IEnumerable<string> OghamText(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return OghamText();
        }
    }

    /// <summary>
    ///  The only unicode alphabet to use a space which isn't empty but should still act like a space.
    /// </summary>
    public string OghamText()
    {
        var index = Random.Number(TheNaughtyStrings.OghamText.Count - 1);
        return TheNaughtyStrings.OghamText[index];
    }

    /// <summary>
    ///  Strings which contain unicode with unusual properties (e.g. Right-to-left override) (c.f. http://www.unicode.org/charts/PDF/U2000.pdf)
    /// </summary>
    public IEnumerable<string> TrickUnicode(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return TrickUnicode();
        }
    }

    /// <summary>
    ///  Strings which contain unicode with unusual properties (e.g. Right-to-left override) (c.f. http://www.unicode.org/charts/PDF/U2000.pdf)
    /// </summary>
    public string TrickUnicode()
    {
        var index = Random.Number(TheNaughtyStrings.TrickUnicode.Count - 1);
        return TheNaughtyStrings.TrickUnicode[index];
    }

    /// <summary>
    ///  Strings which contain "corrupted" text. The corruption will not appear in non-HTML text, however. (via http://www.eeemo.net)
    /// </summary>
    public IEnumerable<string> ZalgoText(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return ZalgoText();
        }
    }

    /// <summary>
    ///  Strings which contain "corrupted" text. The corruption will not appear in non-HTML text, however. (via http://www.eeemo.net)
    /// </summary>
    public string ZalgoText()
    {
        var index = Random.Number(TheNaughtyStrings.ZalgoText.Count - 1);
        return TheNaughtyStrings.ZalgoText[index];
    }

    /// <summary>
    ///  Strings which contain unicode with an "upsidedown" effect (via http://www.upsidedowntext.com)
    /// </summary>
    public IEnumerable<string> UnicodeUpsidedown(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return UnicodeUpsidedown();
        }
    }

    /// <summary>
    ///  Strings which contain unicode with an "upsidedown" effect (via http://www.upsidedowntext.com)
    /// </summary>
    public string UnicodeUpsidedown()
    {
        var index = Random.Number(TheNaughtyStrings.UnicodeUpsidedown.Count - 1);
        return TheNaughtyStrings.UnicodeUpsidedown[index];
    }

    /// <summary>
    ///  Strings which contain bold/italic/etc. versions of normal characters
    /// </summary>
    public IEnumerable<string> Unicodefont(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return Unicodefont();
        }
    }

    /// <summary>
    ///  Strings which contain bold/italic/etc. versions of normal characters
    /// </summary>
    public string Unicodefont()
    {
        var index = Random.Number(TheNaughtyStrings.Unicodefont.Count - 1);
        return TheNaughtyStrings.Unicodefont[index];
    }

    /// <summary>
    ///  Strings which attempt to invoke a benign script injection; shows vulnerability to XSS
    /// </summary>
    public IEnumerable<string> ScriptInjection(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return ScriptInjection();
        }
    }

    /// <summary>
    ///  Strings which attempt to invoke a benign script injection; shows vulnerability to XSS
    /// </summary>
    public string ScriptInjection()
    {
        var index = Random.Number(TheNaughtyStrings.ScriptInjection.Count - 1);
        return TheNaughtyStrings.ScriptInjection[index];
    }

    /// <summary>
    ///  Strings which can cause a SQL injection if inputs are not sanitized
    /// </summary>
    public IEnumerable<string> SQLInjection(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return SQLInjection();
        }
    }

    /// <summary>
    ///  Strings which can cause a SQL injection if inputs are not sanitized
    /// </summary>
    public string SQLInjection()
    {
        var index = Random.Number(TheNaughtyStrings.SQLInjection.Count - 1);
        return TheNaughtyStrings.SQLInjection[index];
    }

    /// <summary>
    ///  Strings which can cause user to run code on server as a privileged user (c.f. https://news.ycombinator.com/item?id=7665153)
    /// </summary>
    public IEnumerable<string> ServerCodeInjection(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return ServerCodeInjection();
        }
    }

    /// <summary>
    ///  Strings which can cause user to run code on server as a privileged user (c.f. https://news.ycombinator.com/item?id=7665153)
    /// </summary>
    public string ServerCodeInjection()
    {
        var index = Random.Number(TheNaughtyStrings.ServerCodeInjection.Count - 1);
        return TheNaughtyStrings.ServerCodeInjection[index];
    }

    /// <summary>
    ///  Strings which can call system commands within Ruby/Rails applications
    /// </summary>
    public IEnumerable<string> CommandInjectionRuby(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return CommandInjectionRuby();
        }
    }

    /// <summary>
    ///  Strings which can call system commands within Ruby/Rails applications
    /// </summary>
    public string CommandInjectionRuby()
    {
        var index = Random.Number(TheNaughtyStrings.CommandInjectionRuby.Count - 1);
        return TheNaughtyStrings.CommandInjectionRuby[index];
    }

    /// <summary>
    ///  Strings which can be accidentally expanded into different strings if evaluated in the wrong context, e.g. used as a printf format string or via Perl or shell eval. Might expose sensitive data from the program doing the interpolation, or might just represent the wrong string.
    /// </summary>
    public IEnumerable<string> UnwantedInterpolation(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return UnwantedInterpolation();
        }
    }

    /// <summary>
    ///  Strings which can be accidentally expanded into different strings if evaluated in the wrong context, e.g. used as a printf format string or via Perl or shell eval. Might expose sensitive data from the program doing the interpolation, or might just represent the wrong string.
    /// </summary>
    public string UnwantedInterpolation()
    {
        var index = Random.Number(TheNaughtyStrings.UnwantedInterpolation.Count - 1);
        return TheNaughtyStrings.UnwantedInterpolation[index];
    }

    /// <summary>
    ///  Strings which can cause user to pull in files that should not be a part of a web server
    /// </summary>
    public IEnumerable<string> FileInclusion(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return FileInclusion();
        }
    }

    /// <summary>
    ///  Strings which can cause user to pull in files that should not be a part of a web server
    /// </summary>
    public string FileInclusion()
    {
        var index = Random.Number(TheNaughtyStrings.FileInclusion.Count - 1);
        return TheNaughtyStrings.FileInclusion[index];
    }

    /// <summary>
    ///  Strings that test for known vulnerabilities
    /// </summary>
    public IEnumerable<string> KnownCVEsandVulnerabilities(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return KnownCVEsandVulnerabilities();
        }
    }

    /// <summary>
    ///  Strings that test for known vulnerabilities
    /// </summary>
    public string KnownCVEsandVulnerabilities()
    {
        var index = Random.Number(TheNaughtyStrings.KnownCVEsandVulnerabilities.Count - 1);
        return TheNaughtyStrings.KnownCVEsandVulnerabilities[index];
    }

    /// <summary>
    ///  Strings which are reserved characters in MSDOS/Windows
    /// </summary>
    public IEnumerable<string> MSDOSWindowsSpecialFilenames(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return MSDOSWindowsSpecialFilenames();
        }
    }

    /// <summary>
    ///  Strings which are reserved characters in MSDOS/Windows
    /// </summary>
    public string MSDOSWindowsSpecialFilenames()
    {
        var index = Random.Number(TheNaughtyStrings.MSDOSWindowsSpecialFilenames.Count - 1);
        return TheNaughtyStrings.MSDOSWindowsSpecialFilenames[index];
    }

    /// <summary>
    ///  Innocuous strings which may be blocked by profanity filters (https://en.wikipedia.org/wiki/Scunthorpe_problem)
    /// </summary>
    public IEnumerable<string> ScunthorpeProblem(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return ScunthorpeProblem();
        }
    }

    /// <summary>
    ///  Innocuous strings which may be blocked by profanity filters (https://en.wikipedia.org/wiki/Scunthorpe_problem)
    /// </summary>
    public string ScunthorpeProblem()
    {
        var index = Random.Number(TheNaughtyStrings.ScunthorpeProblem.Count - 1);
        return TheNaughtyStrings.ScunthorpeProblem[index];
    }

    /// <summary>
    ///  Strings which may cause human to reinterpret worldview
    /// </summary>
    public IEnumerable<string> Humaninjection(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return Humaninjection();
        }
    }

    /// <summary>
    ///  Strings which may cause human to reinterpret worldview
    /// </summary>
    public string Humaninjection()
    {
        var index = Random.Number(TheNaughtyStrings.Humaninjection.Count - 1);
        return TheNaughtyStrings.Humaninjection[index];
    }

    /// <summary>
    ///  Strings which punish the fools who use cat/type on this file
    /// </summary>
    public IEnumerable<string> Terminalescapecodes(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return Terminalescapecodes();
        }
    }

    /// <summary>
    ///  Strings which punish the fools who use cat/type on this file
    /// </summary>
    public string Terminalescapecodes()
    {
        var index = Random.Number(TheNaughtyStrings.Terminalescapecodes.Count - 1);
        return TheNaughtyStrings.Terminalescapecodes[index];
    }

    /// <summary>
    ///  Strings which crashed iMessage in various versions of iOS
    /// </summary>
    public IEnumerable<string> iOSVulnerabilities(uint num = 1)
    {
        for (var i = 0; i < num; i++)
        {
            yield return iOSVulnerabilities();
        }
    }

    /// <summary>
    ///  Strings which crashed iMessage in various versions of iOS
    /// </summary>
    public string iOSVulnerabilities()
    {
        var index = Random.Number(TheNaughtyStrings.iOSVulnerabilities.Count - 1);
        return TheNaughtyStrings.iOSVulnerabilities[index];
    }
}
