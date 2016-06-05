using System.Diagnostics.CodeAnalysis;
using Selkie.Services.Lines.Common.Dto;
using Selkie.Services.Lines.Common.Messages;
using Xunit;

namespace Selkie.Services.Lines.Common.Tests.Messages
{
    [ExcludeFromCodeCoverage]
    public sealed class LineValidationRequestMessageTests
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

        [Fact]
        public void LineDtosDefaultTest()
        {
            Assert.True(m_Dtos == m_Sut.LineDtos);
        }

        [Fact]
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

        [Fact]
        public void Message_Json_Roundtrip()
        {
            // Arrange
            // Act
            LineValidationRequestMessage actual = JsonHelper.RoundtripJsonEncodeDecode(m_Sut);

            // Assert
            Assert.Equal(m_Sut.LineDtos.Length,
                         actual.LineDtos.Length);
        }
    }
}