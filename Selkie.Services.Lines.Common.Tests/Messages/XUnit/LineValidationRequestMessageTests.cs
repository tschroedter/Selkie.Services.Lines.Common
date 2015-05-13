using System.Diagnostics.CodeAnalysis;
using Selkie.Services.Lines.Common.Dto;
using Selkie.Services.Lines.Common.Messages;
using Xunit;

namespace Selkie.Services.Lines.Common.Tests.Messages.XUnit
{
    [ExcludeFromCodeCoverage]
    //ncrunch: no coverage start
    public sealed class LineValidationRequestMessageTests
    {
        private readonly LineDto[] m_Dtos;
        private readonly LineValidationRequestMessage m_Sut;

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

        [Fact]
        public void LineDtosDefaultTest()
        {
            Assert.True(m_Dtos == m_Sut.LineDtos);
        }

        [Fact]
        public void LineDtosRoundtripTest()
        {
            LineDto[] dtos = {
                                 new LineDto(),
                                 new LineDto()
                             };

            m_Sut.LineDtos = dtos;

            Assert.True(dtos == m_Sut.LineDtos);
        }
    }
}