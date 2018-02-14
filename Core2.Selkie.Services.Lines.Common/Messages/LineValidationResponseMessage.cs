using Core2.Selkie.Services.Lines.Common.Dto;
using JetBrains.Annotations;

namespace Core2.Selkie.Services.Lines.Common.Messages
{
    [UsedImplicitly]
    public class LineValidationResponseMessage
    {
        [UsedImplicitly]
        public bool AreValid;

        [NotNull]
        [UsedImplicitly]
        public LineDto[] LineDtos = new LineDto[0];
    }
}