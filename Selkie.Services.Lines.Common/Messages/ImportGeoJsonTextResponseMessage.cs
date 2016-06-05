using JetBrains.Annotations;
using Selkie.Services.Lines.Common.Dto;

namespace Selkie.Services.Lines.Common.Messages
{
    [UsedImplicitly]
    public class ImportGeoJsonTextResponseMessage
    {
        [NotNull]
        [UsedImplicitly]
        public LineDto[] LineDtos = new LineDto[0];
    }
}