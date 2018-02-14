using System;
using System.Diagnostics.CodeAnalysis;
using Core2.Selkie.Services.Lines.Common.Dto;
using Core2.Selkie.Services.Lines.Common.Tests.Messages;
using JetBrains.Annotations;
using NUnit.Framework;

namespace Core2.Selkie.Services.Lines.Common.Tests.Dto
{
    [ExcludeFromCodeCoverage]
    [TestFixture]
    internal sealed class LineDtoTests
    {
        public LineDtoTests()
        {
            m_Sut = new LineDto
                    {
                        Id = 1,
                        IsUnknown = true,
                        RunDirection = "Forward",
                        X1 = 1.0,
                        Y1 = 2.0,
                        X2 = 3.0,
                        Y2 = 4.0
                    };
        }

        private const double Tolerance = 0.1;
        private readonly LineDto m_Sut;

        // ReSharper disable UnusedParameter.Local
        private void AssertLineDtos([NotNull] LineDto expected,
                                    [NotNull] LineDto actual)
        {
            Assert.True(expected.Id == actual.Id,
                        "Id");
            Assert.True(expected.IsUnknown == actual.IsUnknown,
                        "IsUnknown");
            Assert.True(expected.RunDirection == actual.RunDirection,
                        "RunDirection");
            Assert.True(Math.Abs(expected.X1 - actual.X1) < 0.1,
                        "X1");
            Assert.True(Math.Abs(expected.Y1 - actual.Y1) < Tolerance,
                        "Y1");
            Assert.True(Math.Abs(expected.X2 - actual.X2) < Tolerance,
                        "X2");
            Assert.True(Math.Abs(expected.Y2 - actual.Y2) < Tolerance,
                        "Y2");
        }

        // ReSharper restore UnusedParameter.Local

        [Test]
        public void Dto_Json_Roundtrip()
        {
            // Arrange
            // Act
            LineDto actual = JsonHelper.RoundtripJsonEncodeDecode(m_Sut);

            // Assert
            AssertLineDtos(m_Sut,
                           actual);
        }

        [Test]
        public void IdTest()
        {
            Assert.True(1 == m_Sut.Id);
        }

        [Test]
        public void IsUnknownTest()
        {
            Assert.True(m_Sut.IsUnknown);
        }

        [Test]
        public void RunDirectionTest()
        {
            Assert.True("Forward" == m_Sut.RunDirection);
        }

        [Test]
        public void X1Test()
        {
            Assert.True(Math.Abs(1.0 - m_Sut.X1) < 0.1);
        }

        [Test]
        public void X2Test()
        {
            Assert.True(Math.Abs(3.0 - m_Sut.X2) < Tolerance);
        }

        [Test]
        public void Y1Test()
        {
            Assert.True(Math.Abs(2.0 - m_Sut.Y1) < Tolerance);
        }

        [Test]
        public void Y2Test()
        {
            Assert.True(Math.Abs(4.0 - m_Sut.Y2) < Tolerance);
        }
    }
}