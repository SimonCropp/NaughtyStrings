using Bogus.Premium;
using NaughtyStrings.Bogus;

namespace Bogus
{
    public static class NaughtyStringExtensions
    {
        public static Naughty Naughty(this Faker faker)
        {
            Guard.AgainstNull(faker, nameof(faker));
            return ContextHelper.GetOrSet(faker, () => new Naughty());
        }
    }
}