using System.Diagnostics.CodeAnalysis;
using Core2.Selkie.Services.Common.Dto;
using Core2.Selkie.Services.Lines.Common.Messages;
using NUnit.Framework;

namespace Core2.Selkie.Services.Lines.Common.Tests.Messages
{
    [ExcludeFromCodeCoverage]
    [TestFixture]
    internal sealed class ImportGeoJsonTextResponseMessageTests
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

        [Test]
        public void DtosTests()
        {
            Assert.AreEqual(m_Dtos,
                            m_Sut.Dtos);
        }

        [Test]
        public void Message_Json_Roundtrip()
        {
            // Arrange
            // Act
            ImportGeoJsonTextResponseMessage actual = JsonHelper.RoundtripJsonEncodeDecode(m_Sut);

            // Assert
            Assert.AreEqual(m_Sut.Dtos.Length,
                            actual.Dtos.Length);
        }
    }
}