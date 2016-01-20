using JetBrains.Annotations;
using Selkie.Services.Lines.Common.Dto;

namespace Selkie.Services.Lines.Common.Messages
{
    public class ImportGeoJsonTextResponseMessage
    {
        [NotNull]
        public LineDto[] LineDtos = new LineDto[0];
    }
}