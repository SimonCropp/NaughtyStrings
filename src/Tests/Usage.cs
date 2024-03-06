﻿// ReSharper disable UnusedVariable
// ReSharper disable UnusedParameter.Local

public class Usage
{
    public static void Run()
    {
        #region usage

        var items = TheNaughtyStrings.All.Take(10);
        var emoji = TheNaughtyStrings.Emoji.Take(10);

        #endregion
        #region bogususage

        var faker = new Faker<Target>()
            .RuleFor(u => u.Property1, (f, u) => f.Naughty().String())
            .RuleFor(u => u.Property2, (f, u) => f.Naughty().Emoji());

        var target = faker.Generate();
        Debug.WriteLine(target.Property1);
        Debug.WriteLine(target.Property2);

        #endregion
    }
}

public class Target
{
    public string Property1 = null!;
    public string Property2 = null!;
}