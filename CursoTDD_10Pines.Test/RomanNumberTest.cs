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

        [Fact]
        public void Test020To029()
        {
            Assert.Equal("XXI", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(21));
            Assert.Equal("XXIII", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(23));
            Assert.Equal("XXV", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(25));
            Assert.Equal("XXVII", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(27));
            Assert.Equal("XXIX", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(29));
        }

        [Fact]
        public void Test030To039()
        {
            Assert.Equal("XXXI", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(31));
            Assert.Equal("XXXIII", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(33));
            Assert.Equal("XXXV", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(35));
            Assert.Equal("XXXVII", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(37));
            Assert.Equal("XXXIX", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(39));
        }

        [Fact]
        public void Test040To049()
        {
            Assert.Equal("XLI", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(41));
            Assert.Equal("XLIII", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(43));
            Assert.Equal("XLV", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(45));
            Assert.Equal("XLVII", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(47));
            Assert.Equal("XLIX", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(49));
        }

        [Fact]
        public void Test050To089()
        {
            Assert.Equal("LI", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(51));
            Assert.Equal("LIII", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(53));
            Assert.Equal("LXI", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(61));
            Assert.Equal("LXXI", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(71));
            Assert.Equal("LXXXI", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(81));
        }

        [Fact]
        public void Test090To099()
        {
            Assert.Equal("XC", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(90));
            Assert.Equal("XCI", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(91));
            Assert.Equal("XCIII", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(93));
            Assert.Equal("XCV", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(95));
            Assert.Equal("XCVII", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(97));
            Assert.Equal("XCIX", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(99));
        }

        [Fact]
        public void Test100To999()
        {
            Assert.Equal("C", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(100));
            Assert.Equal("CXLIX", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(149));
            Assert.Equal("DCCC", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(800));
            Assert.Equal("CMXCIX", new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(999));
        }

        [Fact]
        public void Test000()
        {
            var exception = Assert.Throws<Exception>(
                () => new CursoTDD_10Pines.RomanNumberTextRepresentation().Of(0)
            );
            Assert.Equal(
                CursoTDD_10Pines.RomanNumberTextRepresentation.ROMAN_NUMBER_HAS_NO_ZERO, 
                exception.Message
            );
        }

    }
}
