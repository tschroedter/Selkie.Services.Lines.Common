using JetBrains.Annotations;
using Selkie.Services.Common.Dto;

namespace Selkie.Services.Lines.Common.Messages
{
    [UsedImplicitly]
    public class ImportGeoJsonTextResponseMessage
    {
        [NotNull]
        [UsedImplicitly]
        public SurveyGeoJsonFeatureDto[] Dtos = new SurveyGeoJsonFeatureDto[0];
    }
}