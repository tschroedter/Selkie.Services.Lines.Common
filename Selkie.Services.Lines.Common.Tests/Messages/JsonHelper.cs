using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Selkie.Services.Lines.Common.Tests.Messages
{
    [UsedImplicitly]
    internal class JsonHelper
    {
        [UsedImplicitly]
        internal static T RoundtripJsonEncodeDecode <T>([NotNull] T instance)
        {
            string encoded = JsonConvert.SerializeObject(instance);
            var decoded = JsonConvert.DeserializeObject <T>(encoded);

            return decoded;
        }
    }
}