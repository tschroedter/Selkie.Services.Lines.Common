using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Selkie.Services.Lines.Common.Tests.Messages.XUnit
{
    internal class JsonHelper
    {
        internal static T RoundtripJsonEncodeDecode <T>([NotNull] T instance)
        {
            string encoded = JsonConvert.SerializeObject(instance);
            var decoded = JsonConvert.DeserializeObject <T>(encoded);

            return decoded;
        }
    }
}