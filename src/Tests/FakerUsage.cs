using System.Diagnostics;
using Bogus;
using Xunit;
using Xunit.Abstractions;

public class FakerUsage
{
    ITestOutputHelper output;

    public FakerUsage(ITestOutputHelper output)
    {
        this.output = output;
    }

    [Fact]
    public void Run()
    {
        var faker = new Faker<Target>()
            .RuleFor(u => u.Property1, (f, u) => f.Naughty().String())
            .RuleFor(u => u.Property2, (f, u) => f.Naughty().Emoji());

        var target = faker.Generate();
        Debug.WriteLine(target.Property1);
        Debug.WriteLine(target.Property2);
    }

    public class Target
    {
        public string Property1 { get; set; }
        public string Property2 { get; set; }
    }
}