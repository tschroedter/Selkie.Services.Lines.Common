using System.Diagnostics.CodeAnalysis;
using Selkie.Services.Lines.Common.Messages;
using Xunit;

namespace Selkie.Services.Lines.Common.Tests.Messages
{
    [ExcludeFromCodeCoverage]
    public sealed class TestLineRequestMessageTests
    {
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

        private readonly TestLineRequestMessage m_Sut;
        private readonly TestLineType.Type[] m_Types;

        [Fact]
        public void ConstructorTest()
        {
            Assert.NotNull(m_Sut);
        }

        [Fact]
        public void Message_Json_Roundtrip()
        {
            // Arrange
            // Act
            TestLineRequestMessage actual = JsonHelper.RoundtripJsonEncodeDecode(m_Sut);

            // Assert
            Assert.Equal(m_Sut.Types.Length,
                         actual.Types.Length);
        }

        [Fact]
        public void TypesDefaultTest()
        {
            Assert.True(m_Types == m_Sut.Types);
        }
    }
}