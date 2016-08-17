using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;

namespace Selkie.Services.Lines.Common
{
    [ExcludeFromCodeCoverage]
    [UsedImplicitly]
    public class TestLineType
    {
        [UsedImplicitly]
        public enum Type
        {
            [UsedImplicitly]
            CreateLines,

            [UsedImplicitly]
            CreateFixedParallelLines,

            [UsedImplicitly]
            CreateParallelLines,

            [UsedImplicitly]
            CreateParallelLinesForwardReverse,

            [UsedImplicitly]
            CreateParallelLinesReverse,

            [UsedImplicitly]
            CreateBox,

            [UsedImplicitly]
            CreateCross,

            [UsedImplicitly]
            CreateCrossForwardReverse,

            [UsedImplicitly]
            CreateParallelCrossLinesInCorner,

            [UsedImplicitly]
            CreateParallelCrossLines,

            [UsedImplicitly]
            CreateParallelCrossLinesForwardReverse,

            [UsedImplicitly]
            CreateLinesInRowHorizontal,

            [UsedImplicitly]
            CreateRandomLines,

            [UsedImplicitly]
            Create45DegreeLines,

            [UsedImplicitly]
            CreateTestLines,

            [UsedImplicitly]
            CreateTestLinesVertical
        }
    }
}