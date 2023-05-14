using Bacon.Ipsum.API.Client.Configuration;
using Bacon.Ipsum.API.Client.Resources;

namespace Bacon.Ipsum.API.Client.Extension
{
    internal static class ParameterParser
    {
        internal static string ToTypeParameter(this TextContentType type)
        {
            return type == TextContentType.ALL_MEAT
                ? TextContentTypes.AllMeat :
                TextContentTypes.MeatAndFiller;
        }
    }
}
