using System.Diagnostics.CodeAnalysis;
using Selkie.Services.Lines.Common.Dto;
using Selkie.Services.Lines.Common.Messages;
using Xunit;

namespace Selkie.Services.Lines.Common.Tests.Messages.XUnit
{
    [ExcludeFromCodeCoverage]
    //ncrunch: no coverage start
    public sealed class LineValidationResponseMessageTest
    {
        private readonly LineDto[] m_Dtos;
        private readonly LineValidationResponseMessage m_Sut;

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

        [Fact]
        public void IsValidDefaultTests()
        {
            Assert.True(m_Sut.AreValid);
        }

        [Fact]
        public void IsValidRoundtripTests()
        {
            m_Sut.AreValid = false;

            Assert.False(m_Sut.AreValid);
        }

        [Fact]
        public void LineDtosDefaultTest()
        {
            Assert.True(m_Dtos == m_Sut.LineDtos);
        }

        [Fact]
        public void LineDtosRoundtripTest()
        {
            var dtos = new LineDto[0];

            m_Sut.LineDtos = dtos;

            Assert.True(dtos == m_Sut.LineDtos);
        }
    }
}