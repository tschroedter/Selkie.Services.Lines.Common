using System.Diagnostics.CodeAnalysis;
using Selkie.Services.Lines.Common.Messages;
using Xunit;

namespace Selkie.Services.Lines.Common.Tests.Messages.XUnit
{
    [ExcludeFromCodeCoverage]
    //ncrunch: no coverage start
    public sealed class ImportGeoJsonFromTextRequestMessageTests
    {
        [Fact]
        public void Message_Json_Roundtrip()
        {
            // Arrange
            var sut = new ImportGeoJsonFromFileRequestMessage
                      {
                          Filename = "Test"
                      };

            // Act
            ImportGeoJsonFromFileRequestMessage actual = JsonHelper.RoundtripJsonEncodeDecode(sut);

            // Assert
            Assert.Equal(sut.Filename,
                         actual.Filename);
        }
    }
}