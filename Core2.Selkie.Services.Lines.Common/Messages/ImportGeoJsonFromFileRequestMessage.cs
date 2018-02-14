using JetBrains.Annotations;

namespace Core2.Selkie.Services.Lines.Common.Messages
{
    public class ImportGeoJsonFromFileRequestMessage
    {
        [NotNull]
        public string Filename = string.Empty;
    }
}