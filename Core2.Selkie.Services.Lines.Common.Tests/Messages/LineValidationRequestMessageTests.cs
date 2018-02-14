using System.Diagnostics.CodeAnalysis;
using Core2.Selkie.Services.Lines.Common.Dto;
using Core2.Selkie.Services.Lines.Common.Messages;
using NUnit.Framework;

namespace Core2.Selkie.Services.Lines.Common.Tests.Messages
{
    [ExcludeFromCodeCoverage]
    [TestFixture]
    internal sealed class LineValidationRequestMessageTests
    {
        public LineValidationRequestMessageTests()
        {
            m_Dtos = new[]
                     {
                         new LineDto()
                     };

            m_Sut = new LineValidationRequestMessage
                    {
                        LineDtos = m_Dtos
                    };
        }

        private readonly LineDto[] m_Dtos;
        private readonly LineValidationRequestMessage m_Sut;

        [Test]
        public void LineDtosDefaultTest()
        {
            Assert.True(m_Dtos == m_Sut.LineDtos);
        }

        [Test]
        public void LineDtosRoundtripTest()
        {
            LineDto[] dtos =
            {
                new LineDto(),
                new LineDto()
            };

            m_Sut.LineDtos = dtos;

            Assert.True(dtos == m_Sut.LineDtos);
        }

        [Test]
        public void Message_Json_Roundtrip()
        {
            // Arrange
            // Act
            LineValidationRequestMessage actual = JsonHelper.RoundtripJsonEncodeDecode(m_Sut);

            // Assert
            Assert.AreEqual(m_Sut.LineDtos.Length,
                            actual.LineDtos.Length);
        }
    }
}