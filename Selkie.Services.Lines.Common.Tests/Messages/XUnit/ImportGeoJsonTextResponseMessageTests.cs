﻿using System.Diagnostics.CodeAnalysis;
using Selkie.Services.Lines.Common.Dto;
using Selkie.Services.Lines.Common.Messages;
using Xunit;

namespace Selkie.Services.Lines.Common.Tests.Messages.XUnit
{
    [ExcludeFromCodeCoverage]
    //ncrunch: no coverage start
    public sealed class ImportGeoJsonTextResponseMessageTests
    {
        private readonly LineDto[] m_LineDtos;
        private readonly ImportGeoJsonTextResponseMessage m_Sut;

        public ImportGeoJsonTextResponseMessageTests()
        {
            m_LineDtos = new[]
                         {
                             new LineDto()
                         };

            m_Sut = new ImportGeoJsonTextResponseMessage
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
            ImportGeoJsonTextResponseMessage actual = JsonHelper.RoundtripJsonEncodeDecode(m_Sut);

            // Assert
            Assert.Equal(m_Sut.LineDtos.Length,
                         actual.LineDtos.Length);
        }
    }
}