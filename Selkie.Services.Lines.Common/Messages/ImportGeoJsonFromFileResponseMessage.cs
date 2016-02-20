using JetBrains.Annotations;
using Selkie.Services.Lines.Common.Dto;

namespace Selkie.Services.Lines.Common.Messages
{
    public class ImportGeoJsonFromFileResponseMessage
    {
        [NotNull]
        public LineDto[] LineDtos = new LineDto[0];
    }
}