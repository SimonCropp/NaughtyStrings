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
            .RuleFor(u => u.Property, (f, u) => f.Naughty().String());

        var target = faker.Generate();
        Debug.WriteLine(target.Property);
    }

    public class Target
    {
        public string Property { get; set; }
    }
}