using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NaughtyStrings;

static class ModuleInit
{
    [ModuleInitializer]
    public static void Initialize()
    {
        var all = (List<string>)TheNaughtyStrings.All;
        all.AddRange(TheNaughtyStrings.SpecialWordCharacters);
    }
}