using System.Diagnostics.CodeAnalysis;
using Core2.Selkie.Services.Lines.Common.Dto;
using Core2.Selkie.Services.Lines.Common.Messages;
using NUnit.Framework;

namespace Core2.Selkie.Services.Lines.Common.Tests.Messages
{
    [ExcludeFromCodeCoverage]
    [TestFixture]
    internal sealed class LineValidationResponseMessageTest
    {
        public LineValidationResponseMessageTest()
        {
            m_Dtos = new[]
                     {
                         new LineDto()
                     };

            m_Sut = new LineValidationResponseMessage
                    {
                        LineDtos = m_Dtos,
                        AreValid = true
                    };
        }

        private readonly LineDto[] m_Dtos;
        private readonly LineValidationResponseMessage m_Sut;

        [Test]
        public void IsValidDefaultTests()
        {
            Assert.True(m_Sut.AreValid);
        }

        [Test]
        public void IsValidRoundtripTests()
        {
            m_Sut.AreValid = false;

            Assert.False(m_Sut.AreValid);
        }

        [Test]
        public void LineDtosDefaultTest()
        {
            Assert.True(m_Dtos == m_Sut.LineDtos);
        }

        [Test]
        public void LineDtosRoundtripTest()
        {
            var dtos = new LineDto[0];

            m_Sut.LineDtos = dtos;

            Assert.True(dtos == m_Sut.LineDtos);
        }

        [Test]
        public void Message_Json_Roundtrip()
        {
            // Arrange
            // Act
            LineValidationResponseMessage actual = JsonHelper.RoundtripJsonEncodeDecode(m_Sut);

            // Assert
            Assert.AreEqual(m_Sut.LineDtos.Length,
                            actual.LineDtos.Length);
        }
    }
}