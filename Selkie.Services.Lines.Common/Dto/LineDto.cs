using JetBrains.Annotations;

namespace Selkie.Services.Lines.Common.Dto
{
    [UsedImplicitly]
    public class LineDto
    {
        [UsedImplicitly]
        public int Id;

        [UsedImplicitly]
        public bool IsUnknown;

        [CanBeNull]
        [UsedImplicitly]
        public string RunDirection;

        [UsedImplicitly]
        public double X1;

        [UsedImplicitly]
        public double X2;

        [UsedImplicitly]
        public double Y1;

        [UsedImplicitly]
        public double Y2;
    }
}