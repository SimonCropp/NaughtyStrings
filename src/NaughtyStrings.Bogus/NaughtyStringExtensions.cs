namespace Bogus;

public static class NaughtyStringExtensions
{
    public static Naughty Naughty(this Faker faker) =>
        ContextHelper.GetOrSet(faker, () => new Naughty());
}