using System.Diagnostics.CodeAnalysis;
using Core2.Selkie.Services.Lines.Common.Messages;
using NUnit.Framework;

namespace Core2.Selkie.Services.Lines.Common.Tests.Messages
{
    [ExcludeFromCodeCoverage]
    [TestFixture]
    internal sealed class ImportGeoJsonTextRequestMessageTests
    {
        [Test]
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
            Assert.AreEqual(sut.Text,
                            actual.Text);
        }
    }
}