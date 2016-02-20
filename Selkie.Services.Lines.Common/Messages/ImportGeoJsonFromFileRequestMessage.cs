using JetBrains.Annotations;

namespace Selkie.Services.Lines.Common.Messages
{
    public class ImportGeoJsonFromFileRequestMessage
    {
        [NotNull]
        public string Filename = string.Empty;
    }
}