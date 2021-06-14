package ec.com.ndeveloper.shop;

import static org.junit.Assert.assertFalse;
import static org.junit.Assert.assertTrue;

import java.time.LocalDate;
import java.time.YearMonth;
import java.util.HashMap;

import org.junit.Test;

public class MerchantTest {

	@Test
	public void validateServiceOn() throws Exception {
		Cart cart = new Cart();
		Book book = new Book("EL SEÑOR DE LOS ANILLOS");
		Item item = new Item(book, 1);
		cart.addItem(item);
		cart.addItem(item);
		HashMap<Book, Double> catalogePrices = new HashMap<Book, Double>();
		catalogePrices.put(new Book("EL SEÑOR DE LOS ANILLOS"), 10.0);
		CreditCard aCreditCard = new CreditCard(YearMonth.of(2021, 5),"123456781234","PEPITO DE LOS PALOTES");
		MerchantPass merchantPass = new MerchantPassSimulator(true);
		Cashier aCashier = new Cashier(cart,catalogePrices,aCreditCard, LocalDate.of(2019, 1, 1),merchantPass);
		assertTrue(aCashier.getMerchantPass().isAvaible());
	}
	
	@Test
	public void validateServiceOff() throws Exception {
		Cart cart = new Cart();
		Book book = new Book("EL SEÑOR DE LOS ANILLOS");
		Item item = new Item(book, 1);
		cart.addItem(item);
		cart.addItem(item);
		HashMap<Book, Double> catalogePrices = new HashMap<Book, Double>();
		catalogePrices.put(new Book("EL SEÑOR DE LOS ANILLOS"), 10.0);
		CreditCard aCreditCard = new CreditCard(YearMonth.of(2021, 5),"123456781234","PEPITO DE LOS PALOTES");
		MerchantPass merchantPass = new MerchantPassSimulator(false);
		Cashier aCashier = new Cashier(cart,catalogePrices,aCreditCard, LocalDate.of(2019, 1, 1),merchantPass);
		assertFalse(aCashier.getMerchantPass().isAvaible());
	}
	
	
}
