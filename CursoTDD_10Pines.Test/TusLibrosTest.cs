using CursoTDD_10Pines;
using System;
using System.Linq;
using System.Collections.Generic;
using Xunit;

namespace Test
{
    public class TusLibrosTest
    {
        [Fact]
        public void ComenzarCompraConCarrito()
        {
            var cart = EmptyCart();
            Assert.Empty(cart);
        }

        [Fact]
        public void AgregarLibroACarrito()
        {
            var cart = EmptyCart();
            var book = ValidBook();

            cart.Add(book);

            Assert.Contains(book, cart);
        }

        [Fact]
        public void AgregarMasDe1LibroDistintoACarrito()
        {
            var cart = EmptyCart();
            var book = ValidBook();
            var book2 = AnotherBook();

            cart.Add(book);
            cart.Add(book2);

            Assert.Contains(book, cart);
            Assert.Contains(book2, cart);
        }

        [Fact]
        public void AgregarMasDe1LibroIgualACarrito()
        {
            var cart = EmptyCart();
            var book = ValidBook();
            var book2 = ValidBook();

            cart.Add(book);
            cart.Add(book2);

            Assert.Contains(book, cart);
            Assert.Equal(2, cart.Count(a => a == book));
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
