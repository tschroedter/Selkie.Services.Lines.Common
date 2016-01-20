using JetBrains.Annotations;

namespace Selkie.Services.Lines.Common.Messages
{
    public class ImportGeoJsonTextRequestMessage
    {
        [NotNull]
        public string Text = string.Empty;
    }
}