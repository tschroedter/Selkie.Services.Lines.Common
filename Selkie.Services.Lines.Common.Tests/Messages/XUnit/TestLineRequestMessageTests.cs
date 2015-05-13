using System.Diagnostics.CodeAnalysis;
using Selkie.Services.Lines.Common.Messages;
using Xunit;

namespace Selkie.Services.Lines.Common.Tests.Messages.XUnit
{
    [ExcludeFromCodeCoverage]
    //ncrunch: no coverage start
    internal sealed class TestLineRequestMessageTests
    {
        private readonly TestLineRequestMessage m_Sut;
        private readonly TestLineType.Type[] m_Types;

        public TestLineRequestMessageTests()
        {
            m_Types = new[]
                      {
                          TestLineType.Type.CreateLines
                      };

            m_Sut = new TestLineRequestMessage
                    {
                        Types = m_Types
                    };
        }

        [Fact]
        public void ConstructorTest()
        {
            Assert.NotNull(m_Sut);
        }

        [Fact]
        public void TypesDefaultTest()
        {
            Assert.True(m_Types == m_Sut.Types);
        }
    }
}