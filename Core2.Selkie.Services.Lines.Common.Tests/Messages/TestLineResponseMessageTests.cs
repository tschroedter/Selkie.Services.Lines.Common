using System.Diagnostics.CodeAnalysis;
using Core2.Selkie.Services.Lines.Common.Dto;
using Core2.Selkie.Services.Lines.Common.Messages;
using NUnit.Framework;

namespace Core2.Selkie.Services.Lines.Common.Tests.Messages.XUnit
{
    [ExcludeFromCodeCoverage]
    [TestFixture]
    internal sealed class TestLineResponseMessageTests
    {
        public TestLineResponseMessageTests()
        {
            m_LineDtos = new[]
                         {
                             new LineDto()
                         };

            m_Sut = new TestLineResponseMessage
                    {
                        LineDtos = m_LineDtos
                    };
        }

        private readonly LineDto[] m_LineDtos;
        private readonly TestLineResponseMessage m_Sut;

        [Test]
        public void LineDtosTests()
        {
            Assert.AreEqual(m_LineDtos,
                            m_Sut.LineDtos);
        }

        [Test]
        public void Message_Json_Roundtrip()
        {
            // Arrange
            // Act
            TestLineResponseMessage actual = JsonHelper.RoundtripJsonEncodeDecode(m_Sut);

            // Assert
            Assert.AreEqual(m_Sut.LineDtos.Length,
                            actual.LineDtos.Length);
        }
    }
}