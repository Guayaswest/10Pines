package ec.com.ndeveloper.shop;

import java.util.ArrayList;
import java.util.List;

public class Cart {

	private List<Item> items;

	public Cart() {
		super();
		this.items = new ArrayList<Item>();
	}

	public void addItem(Item item) {
		if (isContains(item)) {
			Item bookRegister = getItem(item.getBook());
			bookRegister.addQuantity(item.getQuantity());
		} else {
			this.items.add(item);
		}
	}

	private Item getItem(Book book) {
		for (Item item : items) {
			if (item.getBook().equals(book)) {
				return item;
			}
		}
		return null;

	}

	public Boolean isEmpty() {
		return this.items.isEmpty();
	}

	public Boolean isContains(Item item) {
		return this.items.contains(item);

	}

	public Integer getQuantity(Book book) {
		Item result = getItem(book);
		return result.getQuantity();
	}

	public List<Item> getItems() {
		return items;
	}

	public void setItems(List<Item> items) {
		this.items = items;
	}

}
