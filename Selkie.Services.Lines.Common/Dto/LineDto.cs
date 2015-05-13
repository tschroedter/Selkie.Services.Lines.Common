using JetBrains.Annotations;

namespace Selkie.Services.Lines.Common.Dto
{
    public class LineDto
    {
        public int Id;
        public bool IsUnknown;

        [CanBeNull]
        public string RunDirection;

        public double X1;
        public double X2;
        public double Y1;
        public double Y2;
    }
}