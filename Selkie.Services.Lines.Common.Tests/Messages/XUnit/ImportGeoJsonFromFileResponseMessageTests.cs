using System.Diagnostics.CodeAnalysis;
using Selkie.Services.Lines.Common.Dto;
using Selkie.Services.Lines.Common.Messages;
using Xunit;

namespace Selkie.Services.Lines.Common.Tests.Messages.XUnit
{
    [ExcludeFromCodeCoverage]
    //ncrunch: no coverage start
    public sealed class ImportGeoJsonFromFileResponseMessageTests
    {
        private readonly LineDto[] m_LineDtos;
        private readonly ImportGeoJsonFromFileResponseMessage m_Sut;

        public ImportGeoJsonFromFileResponseMessageTests()
        {
            m_LineDtos = new[]
                         {
                             new LineDto()
                         };

            m_Sut = new ImportGeoJsonFromFileResponseMessage
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

        [Fact]
        public void Message_Json_Roundtrip()
        {
            // Arrange
            // Act
            ImportGeoJsonFromFileResponseMessage actual = JsonHelper.RoundtripJsonEncodeDecode(m_Sut);

            // Assert
            Assert.Equal(m_Sut.LineDtos.Length,
                         actual.LineDtos.Length);
        }
    }
}