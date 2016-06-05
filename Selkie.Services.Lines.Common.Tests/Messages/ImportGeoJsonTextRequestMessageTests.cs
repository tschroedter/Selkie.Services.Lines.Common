using System.Diagnostics.CodeAnalysis;
using Selkie.Services.Lines.Common.Messages;
using Xunit;

namespace Selkie.Services.Lines.Common.Tests.Messages
{
    [ExcludeFromCodeCoverage]
    public sealed class ImportGeoJsonTextRequestMessageTests
    {
        [Fact]
        public void Message_Json_Roundtrip()
        {
            // Arrange
            var sut = new ImportGeoJsonTextRequestMessage
                      {
                          Text = "Test"
                      };

            // Act
            ImportGeoJsonTextRequestMessage actual = JsonHelper.RoundtripJsonEncodeDecode(sut);

            // Assert
            Assert.Equal(sut.Text,
                         actual.Text);
        }
    }
}