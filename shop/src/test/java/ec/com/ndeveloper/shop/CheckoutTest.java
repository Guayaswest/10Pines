package ec.com.ndeveloper.shop;

import static org.junit.Assert.assertThrows;
import static org.junit.Assert.assertTrue;

import java.time.LocalDate;
import java.time.YearMonth;
import java.util.HashMap;

import org.junit.Test;

public class CheckoutTest {
	
	@Test
	public void validateEmptyCart() {
		Cart cart = new Cart();
		assertThrows(Exception.class, ()-> {new Cashier(cart);});
	}
	
	@Test
	public void validateAmmount() throws Exception {
		Cart cart = new Cart();
		Book book = new Book("EL SEÑOR DE LOS ANILLOS");
		Item item = new Item(book, 1);
		cart.addItem(item);
		cart.addItem(item);
		HashMap<Book, Double> catalogePrices = new HashMap<Book, Double>();
		catalogePrices.put(new Book("EL SEÑOR DE LOS ANILLOS"), 10.0);
		Cashier aCashier = new Cashier(cart,catalogePrices);
		Double ammount = aCashier.calculateAmmount();
		assertTrue(ammount.equals(20.0));
	}
	
	@Test
	public void validateCheckout() throws Exception{
		Cart cart = new Cart();
		Book book = new Book("EL SEÑOR DE LOS ANILLOS");
		Item item = new Item(book, 1);
		cart.addItem(item);
		CreditCard aCreditCard = new CreditCard(YearMonth.of(2021, 5),"123456781234","PEPITO DE LOS PALOTES");
		HashMap<Book, Double> catalogePrices = new HashMap<Book, Double>();
		catalogePrices.put(new Book("EL SEÑOR DE LOS ANILLOS"), 10.0);
		assertThrows(Exception.class, ()-> {new Cashier(cart,catalogePrices,aCreditCard, LocalDate.of(2025, 1, 1));});
	}

}
