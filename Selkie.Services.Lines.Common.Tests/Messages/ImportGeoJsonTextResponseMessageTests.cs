using System.Diagnostics.CodeAnalysis;
using Selkie.Services.Common.Dto;
using Selkie.Services.Lines.Common.Messages;
using Xunit;

namespace Selkie.Services.Lines.Common.Tests.Messages
{
    [ExcludeFromCodeCoverage]
    public sealed class ImportGeoJsonTextResponseMessageTests
    {
        public ImportGeoJsonTextResponseMessageTests()
        {
            m_Dtos = new[]
                     {
                         new SurveyGeoJsonFeatureDto()
                     };

            m_Sut = new ImportGeoJsonTextResponseMessage
                    {
                        Dtos = m_Dtos
                    };
        }

        private readonly SurveyGeoJsonFeatureDto[] m_Dtos;
        private readonly ImportGeoJsonTextResponseMessage m_Sut;

        [Fact]
        public void DtosTests()
        {
            Assert.Equal(m_Dtos,
                         m_Sut.Dtos);
        }

        [Fact]
        public void Message_Json_Roundtrip()
        {
            // Arrange
            // Act
            ImportGeoJsonTextResponseMessage actual = JsonHelper.RoundtripJsonEncodeDecode(m_Sut);

            // Assert
            Assert.Equal(m_Sut.Dtos.Length,
                         actual.Dtos.Length);
        }
    }
}