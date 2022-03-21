using Bogus.Premium;
using NaughtyStrings.Bogus;

namespace Bogus;

public static class NaughtyStringExtensions
{
    public static Naughty Naughty(this Faker faker) =>
        ContextHelper.GetOrSet(faker, () => new Naughty());
}