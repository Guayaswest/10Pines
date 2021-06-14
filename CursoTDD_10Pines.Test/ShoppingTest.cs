using CursoTDD_10Pines;
using System;
using System.Linq;
using System.Collections.Generic;
using Xunit;
using System.Text.RegularExpressions;

namespace Test
{
    public class ShoppingTest
    {
        [Fact]
        public void ValidarFechaVencimintoTarjeta()
        {
            var tarjetaFechaVencimientoString = "062021";
            Assert.Matches("[0-9]{1,6}", tarjetaFechaVencimientoString);
            Assert.True(IsValidDateCard(tarjetaFechaVencimientoString));
        }

        private bool IsValidDateCard(string tarjetaFechaVencimientoString)
        {
            var month = tarjetaFechaVencimientoString.Substring(0, 2);
            var year = tarjetaFechaVencimientoString.Substring(2, 4);

            var currentDate = new DateTime(2021, 5, 1);
            var validDate = new DateTime(int.Parse(year), int.Parse(month), 1);

            return validDate > currentDate;
        }

        private object ValidBook()
        {
            return "";
        }

        private object AnotherBook()
        {
            return "";
        }

        private List<Object> EmptyCart()
        {
            return new List<Object>();
        }
    }
}
