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
        var testUsers = new Faker<Target>()
            .RuleFor(u => u.Property, (f, u) => f.Naughty().String());

        var user = testUsers.Generate();
        output.WriteLine(user.Property);
    }

    public class Target
    {
        public string Property { get; set; }
    }
}