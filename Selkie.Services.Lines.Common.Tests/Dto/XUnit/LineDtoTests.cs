using System;
using System.Diagnostics.CodeAnalysis;
using Selkie.Services.Lines.Common.Dto;
using Xunit;

namespace Selkie.Services.Lines.Common.Tests.Dto.XUnit
{
    [ExcludeFromCodeCoverage]
    //ncrunch: no coverage start
    public sealed class LineDtoTests
    {
        private const double Tolerance = 0.1;
        private readonly LineDto m_Sut;

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

        [Fact]
        public void IdTest()
        {
            Assert.True(1 == m_Sut.Id);
        }

        [Fact]
        public void IsUnknownTest()
        {
            Assert.True(m_Sut.IsUnknown);
        }

        [Fact]
        public void RunDirectionTest()
        {
            Assert.True("Forward" == m_Sut.RunDirection);
        }

        [Fact]
        public void X1Test()
        {
            Assert.True(Math.Abs(1.0 - m_Sut.X1) < 0.1);
        }

        [Fact]
        public void Y1Test()
        {
            Assert.True(Math.Abs(2.0 - m_Sut.Y1) < Tolerance);
        }

        [Fact]
        public void X2Test()
        {
            Assert.True(Math.Abs(3.0 - m_Sut.X2) < Tolerance);
        }

        [Fact]
        public void Y2Test()
        {
            Assert.True(Math.Abs(4.0 - m_Sut.Y2) < Tolerance);
        }
    }
}