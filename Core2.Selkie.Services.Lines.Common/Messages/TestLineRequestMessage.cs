using JetBrains.Annotations;

namespace Core2.Selkie.Services.Lines.Common.Messages
{
    [UsedImplicitly]
    public class TestLineRequestMessage
    {
        [NotNull]
        [UsedImplicitly]
        public TestLineType.Type[] Types = new TestLineType.Type[0];
    }
}