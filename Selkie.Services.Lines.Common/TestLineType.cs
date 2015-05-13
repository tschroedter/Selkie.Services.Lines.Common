using System.Diagnostics.CodeAnalysis;

namespace Selkie.Services.Lines.Common
{
    [ExcludeFromCodeCoverage]
    //ncrunch: no coverage start
    public class TestLineType
    {
        public enum Type
        {
            CreateLines,
            CreateFixedParallelLines,
            CreateParallelLines,
            CreateParallelLinesForwardReverse,
            CreateParallelLinesReverse,
            CreateBox,
            CreateCross,
            CreateCrossForwardReverse,
            CreateParallelCrossLinesInCorner,
            CreateParallelCrossLines,
            CreateParallelCrossLinesForwardReverse,
            CreateLinesInRowHorizontal,
            CreateRandomLines,
            Create45DegreeLines,
            CreateTestLines,
            CreateTestLinesVertical
        }
    }
}