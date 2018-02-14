using Core2.Selkie.Services.Common.Dto;
using JetBrains.Annotations;

namespace Core2.Selkie.Services.Lines.Common.Messages
{
    [UsedImplicitly]
    public class ImportGeoJsonTextResponseMessage
    {
        [NotNull]
        [UsedImplicitly]
        public SurveyGeoJsonFeatureDto[] Dtos = new SurveyGeoJsonFeatureDto[0];
    }
}