using CursoTDD_10Pines;
using System;
using Xunit;

namespace Test
{
    public class RomanNumberTest
    {
        [Fact]
        public void Test001()
        {
            Assert.Equal("I", new RomanNumberTextRepresentation().Of(1));
        }
        [Fact]
        public void Test002()
        {
            Assert.Equal("II", new RomanNumberTextRepresentation().Of(2));
        }
        [Fact]
        public void Test003()
        {
            Assert.Equal("III", new RomanNumberTextRepresentation().Of(3));
        }
        [Fact]
        public void Test004()
        {
            Assert.Equal("IV", new RomanNumberTextRepresentation().Of(4));
        }
        [Fact]
        public void Test005()
        {
            Assert.Equal("V", new RomanNumberTextRepresentation().Of(5));
        }
        [Fact]
        public void Test006()
        {
            Assert.Equal("VI", new RomanNumberTextRepresentation().Of(6));
        }
        [Fact]
        public void Test007()
        {
            Assert.Equal("VII", new RomanNumberTextRepresentation().Of(7));
        }
        [Fact]
        public void Test008()
        {
            Assert.Equal("VIII", new RomanNumberTextRepresentation().Of(8));
        }
        [Fact]
        public void Test009()
        {
            Assert.Equal("IX", new RomanNumberTextRepresentation().Of(9));
        }
        [Fact]
        public void Test010()
        {
            Assert.Equal("X", new RomanNumberTextRepresentation().Of(10));
        }
        [Fact]
        public void Test011()
        {
            Assert.Equal("XI", new RomanNumberTextRepresentation().Of(11));
        }
        [Fact]
        public void Test012()
        {
            Assert.Equal("XII", new RomanNumberTextRepresentation().Of(12));
        }

        [Fact]
        public void Test020To029()
        {
            Assert.Equal("XXI", new RomanNumberTextRepresentation().Of(21));
            Assert.Equal("XXIII", new RomanNumberTextRepresentation().Of(23));
            Assert.Equal("XXV", new RomanNumberTextRepresentation().Of(25));
            Assert.Equal("XXVII", new RomanNumberTextRepresentation().Of(27));
            Assert.Equal("XXIX", new RomanNumberTextRepresentation().Of(29));
        }

        [Fact]
        public void Test030To039()
        {
            Assert.Equal("XXXI", new RomanNumberTextRepresentation().Of(31));
            Assert.Equal("XXXIII", new RomanNumberTextRepresentation().Of(33));
            Assert.Equal("XXXV", new RomanNumberTextRepresentation().Of(35));
            Assert.Equal("XXXVII", new RomanNumberTextRepresentation().Of(37));
            Assert.Equal("XXXIX", new RomanNumberTextRepresentation().Of(39));
        }

        [Fact]
        public void Test040To049()
        {
            Assert.Equal("XLI", new RomanNumberTextRepresentation().Of(41));
            Assert.Equal("XLIII", new RomanNumberTextRepresentation().Of(43));
            Assert.Equal("XLV", new RomanNumberTextRepresentation().Of(45));
            Assert.Equal("XLVII", new RomanNumberTextRepresentation().Of(47));
            Assert.Equal("XLIX", new RomanNumberTextRepresentation().Of(49));
        }

        [Fact]
        public void Test050To089()
        {
            Assert.Equal("LI", new RomanNumberTextRepresentation().Of(51));
            Assert.Equal("LIII", new RomanNumberTextRepresentation().Of(53));
            Assert.Equal("LXI", new RomanNumberTextRepresentation().Of(61));
            Assert.Equal("LXXI", new RomanNumberTextRepresentation().Of(71));
            Assert.Equal("LXXXI", new RomanNumberTextRepresentation().Of(81));
        }

        [Fact]
        public void Test090To099()
        {
            Assert.Equal("XC", new RomanNumberTextRepresentation().Of(90));
            Assert.Equal("XCI", new RomanNumberTextRepresentation().Of(91));
            Assert.Equal("XCIII", new RomanNumberTextRepresentation().Of(93));
            Assert.Equal("XCV", new RomanNumberTextRepresentation().Of(95));
            Assert.Equal("XCVII", new RomanNumberTextRepresentation().Of(97));
            Assert.Equal("XCIX", new RomanNumberTextRepresentation().Of(99));
        }

        [Fact]
        public void Test100To999()
        {
            Assert.Equal("C", new RomanNumberTextRepresentation().Of(100));
            Assert.Equal("CXLIX", new RomanNumberTextRepresentation().Of(149));
            Assert.Equal("DCCC", new RomanNumberTextRepresentation().Of(800));
            Assert.Equal("CMXCIX", new RomanNumberTextRepresentation().Of(999));
        }

        [Fact]
        public void Test000()
        {
            var exception = Assert.Throws<Exception>(
                () => new RomanNumberTextRepresentation().Of(0)
            );
            Assert.Equal(
                RomanNumberTextRepresentation.ROMAN_NUMBER_HAS_NO_ZERO, 
                exception.Message
            );
        }

    }
}
