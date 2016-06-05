using JetBrains.Annotations;

namespace Selkie.Services.Lines.Common.Messages
{
    [UsedImplicitly]
    public class ImportGeoJsonTextRequestMessage
    {
        [NotNull]
        [UsedImplicitly]
        public string Text = string.Empty;
    }
}