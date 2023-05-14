using Bacon.Ipsum.API.Client.Configuration;
using Bogus;

namespace Bacon.Ipsum.API.Client.Fixture
{
    public static class BaconIpsumApiClientConfigurationFixture
    {
        public static BaconIpsumApiClientConfiguration AutoGenerate()
        {
            return new Faker<BaconIpsumApiClientConfiguration>()
                .RuleFor(u => u.StartWithLorem, (f) => f.Random.Bool())
                .RuleFor(u => u.Type, (f) => f.Random.Enum<TextContentType>())
                .RuleFor(u => u.ThrowOnAnyError, (f) => f.Random.Bool())
                .RuleFor(u => u.BaseUrl, (f) => f.Internet.UrlRootedPath())
                .RuleFor(u => u.MaxTimeout, (f) => f.Random.Int(1000, 10000))
                .Generate();
        }
    }
}
