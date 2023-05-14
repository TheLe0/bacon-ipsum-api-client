using Bogus;

namespace Bacon.Ipsum.API.Client.Fixture
{
    public static class TextGeneratorFixture
    {
        public static IEnumerable<string> AutoGenerate(int size)
        {
            return new Faker()
                .Random.WordsArray(size);
        }
    }
}