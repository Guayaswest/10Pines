using System;
using Xunit;

namespace CursoTDD_10Pines.Test
{
    public class RomanNumberTest
    {
        [Fact]
        public void Test001()
        {
            Assert.Equal("I", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(1));
        }
        [Fact]
        public void Test002()
        {
            Assert.Equal("II", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(2));
        }
        [Fact]
        public void Test003()
        {
            Assert.Equal("III", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(3));
        }
        [Fact]
        public void Test004()
        {
            Assert.Equal("IV", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(4));
        }
        [Fact]
        public void Test005()
        {
            Assert.Equal("V", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(5));
        }
        [Fact]
        public void Test006()
        {
            Assert.Equal("VI", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(6));
        }
        [Fact]
        public void Test007()
        {
            Assert.Equal("VII", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(7));
        }
        [Fact]
        public void Test008()
        {
            Assert.Equal("VIII", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(8));
        }
        [Fact]
        public void Test009()
        {
            Assert.Equal("IX", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(9));
        }
        [Fact]
        public void Test010()
        {
            Assert.Equal("X", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(10));
        }
        [Fact]
        public void Test011()
        {
            Assert.Equal("XI", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(11));
        }
        [Fact]
        public void Test012()
        {
            Assert.Equal("XII", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(12));
        }
    }
}
