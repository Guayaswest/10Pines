package ec.com.ndeveloper.shop;

import static org.junit.Assert.assertTrue;

import org.junit.Test;

public class ShoppingTest {
	
	@Test
	public void validateEmptyCart() {
		Cart cart = new Cart();
		assertTrue(cart.isEmpty());
	}
	
	@Test
	public void validateAddCart() {
		Cart cart = new Cart();
		Book book = new Book("EL SEÑOR DE LOS ANILLOS");
		Item item = new Item(book, 1);
		cart.addItem(item);
		assertTrue(cart.isContains(item));
	}
	
	@Test
	public void validateDifferentBook() {
		Cart cart = new Cart();
		Book book = new Book("EL SEÑOR DE LOS ANILLOS");
		Book book2 = new Book("HARRY POTTER");
		Item item = new Item(book, 1);
		Item item2 = new Item(book2, 1);
		cart.addItem(item);
		cart.addItem(item2);
		assertTrue(cart.isContains(item));
		assertTrue(cart.isContains(item2));
	}

	@Test
	public void validateSameBook() {
		Cart cart = new Cart();
		Book book = new Book("EL SEÑOR DE LOS ANILLOS");
		Item item = new Item(book, 1);
		cart.addItem(item);
		item = new Item(book, 5);
		cart.addItem(item);
		Integer quantity = cart.getQuantity(book);
		assertTrue(cart.isContains(item));
		assertTrue(quantity == 6);
	}
}
