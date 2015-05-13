using JetBrains.Annotations;
using Selkie.Services.Lines.Common.Dto;

namespace Selkie.Services.Lines.Common.Messages
{
    public class LineValidationResponseMessage
    {
        public bool AreValid;

        [NotNull]
        public LineDto[] LineDtos = new LineDto[0];
    }
}