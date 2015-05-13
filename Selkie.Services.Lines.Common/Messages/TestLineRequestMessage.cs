using JetBrains.Annotations;

namespace Selkie.Services.Lines.Common.Messages
{
    public class TestLineRequestMessage
    {
        [NotNull]
        public TestLineType.Type[] Types = new TestLineType.Type[0];
    }
}