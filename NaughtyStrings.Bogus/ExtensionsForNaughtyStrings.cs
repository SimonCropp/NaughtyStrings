using Bogus;
using Bogus.Premium;

namespace NaughtyStrings.Bogus
{
    public static class ExtensionsForNaughtyStrings
    {
        public static Naughty Naughty(this Faker faker)
        {
            return ContextHelper.GetOrSet(faker, () => new Naughty());
        }
    }
}