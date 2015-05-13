using System.Diagnostics.CodeAnalysis;
using Selkie.Services.Lines.Common.Dto;
using Selkie.Services.Lines.Common.Messages;
using Xunit;

namespace Selkie.Services.Lines.Common.Tests.Messages.XUnit
{
    [ExcludeFromCodeCoverage]
    //ncrunch: no coverage start
    internal sealed class TestLineResponseMessageTests
    {
        private readonly LineDto[] m_LineDtos;
        private readonly TestLineResponseMessage m_Sut;

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

        [Fact]
        public void LineDtosTests()
        {
            Assert.Equal(m_LineDtos,
                         m_Sut.LineDtos);
        }
    }
}