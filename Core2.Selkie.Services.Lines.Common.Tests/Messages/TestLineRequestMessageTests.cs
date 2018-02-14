using System.Diagnostics.CodeAnalysis;
using Core2.Selkie.Services.Lines.Common.Messages;
using NUnit.Framework;

namespace Core2.Selkie.Services.Lines.Common.Tests.Messages
{
    [ExcludeFromCodeCoverage]
    [TestFixture]
    internal sealed class TestLineRequestMessageTests
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

        [Test]
        public void ConstructorTest()
        {
            Assert.NotNull(m_Sut);
        }

        [Test]
        public void Message_Json_Roundtrip()
        {
            // Arrange
            // Act
            TestLineRequestMessage actual = JsonHelper.RoundtripJsonEncodeDecode(m_Sut);

            // Assert
            Assert.AreEqual(m_Sut.Types.Length,
                            actual.Types.Length);
        }

        [Test]
        public void TypesDefaultTest()
        {
            Assert.True(m_Types == m_Sut.Types);
        }
    }
}