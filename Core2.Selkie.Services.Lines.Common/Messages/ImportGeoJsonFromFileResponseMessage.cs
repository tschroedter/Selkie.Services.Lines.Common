using JetBrains.Annotations;
using Core2.Selkie.Services.Lines.Common.Dto;

namespace Core2.Selkie.Services.Lines.Common.Messages
{
    public class ImportGeoJsonFromFileResponseMessage
    {
        [NotNull]
        public LineDto[] LineDtos = new LineDto[0];
    }
}