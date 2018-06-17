# NaughtyStrings

Provides a strong typed .NET API for [big-list-of-naughty-strings](https://github.com/minimaxir/big-list-of-naughty-strings)


## NaughtyStrings  [![NuGet Status](http://img.shields.io/nuget/v/NaughtyStrings.svg?style=flat)](https://www.nuget.org/packages/NaughtyStrings/)

https://nuget.org/packages/NaughtyStrings/

    PM> Install-Package NaughtyStrings


### Usage

The entry type is a static class `TheNaughtyStrings`. It exposes all strings via `TheNaughtyStrings.All` and individual categories by name:

```csharp
var items = TheNaughtyStrings.All.Take(10);
var emoji = TheNaughtyStrings.Emoji.Take(10);
```

## NaughtyStrings.Bogus [![NuGet Status](http://img.shields.io/nuget/v/NaughtyStrings.Bogus.svg?style=flat)](https://www.nuget.org/packages/NaughtyStrings.Bogus/)

Extends [Bogus](https://github.com/bchavez/Bogus) to use Naughty Strings.

https://nuget.org/packages/NaughtyStrings.Bogus/

    PM> Install-Package NaughtyStrings.Bogus


### Usage


The entry extension method is `Naughty()`. It exposes all strings via `.String()` and individual categories by name:

```csharp
var faker = new Faker<Target>()
    .RuleFor(u => u.Property1, (f, u) => f.Naughty().String())
    .RuleFor(u => u.Property2, (f, u) => f.Naughty().Emoji());

var target = faker.Generate();
Debug.WriteLine(target.Property1);
Debug.WriteLine(target.Property2);
```


## Usage in Xunit

The below example uses the `MemberDataAttribute` to consume all naughty strings from a helper class. See  [Creating parameterised tests in xUnit with [InlineData], [ClassData], and [MemberData]
](https://andrewlock.net/creating-parameterised-tests-in-xunit-with-inlinedata-classdata-and-memberdata/#loadingdatafromapropertyormethodonadifferentclass) and [xUnit Theory: Working With InlineData, MemberData, ClassData](http://hamidmosalla.com/2017/02/25/xunit-theory-working-with-inlinedata-memberdata-classdata/) for more information.

```csharp
public class XunitUsage
{
    ITestOutputHelper output;

    public XunitUsage(ITestOutputHelper output)
    {
        this.output = output;
    }

    [Theory]
    [MemberData(
        memberName: nameof(NaughtyDataProvider.GetData),
        MemberType = typeof(NaughtyDataProvider))]
    public void Run(string naughtyString)
    {
        output.WriteLine(naughtyString);
    }
}

public class NaughtyDataProvider
{
    public static IEnumerable<object[]> GetData()
    {
        foreach (var naughtyString in TheNaughtyStrings.All)
        {
            yield return new object[] { naughtyString };
        }
    }
}
```


## Icon

<a href="https://thenounproject.com/term/naughty/1777956/" target="_blank">Naughty</a> designed by <a href="https://thenounproject.com/AomAm/" target="_blank">AomAm</a> from The Noun Project