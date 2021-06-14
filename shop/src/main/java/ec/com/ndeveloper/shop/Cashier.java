package ec.com.ndeveloper.shop;

import java.time.LocalDate;
import java.util.HashMap;
import java.util.Map;

public class Cashier {

	private Cart cart;
	private CreditCard aCreditCard;
	private HashMap<Book, Double> catalogePrices;
	private MerchantPass merchantPass;

	public Cashier(Cart cart) throws Exception {
		this.cart = cart;
		if(this.cart.isEmpty()) {
			throw new Exception("Carro de compras vacio");
		}
	}

	public Cashier(Cart cart, HashMap<Book, Double> catalogePrices) throws Exception {
		this.cart = cart;
		this.catalogePrices = catalogePrices;
		if(this.cart.isEmpty() || this.catalogePrices.isEmpty()) {
			throw new Exception("Carro de compras vacio o Precios vacio");
		}
	}

	public Cashier(Cart cart, HashMap<Book, Double> catalogePrices, CreditCard aCreditCard, LocalDate currentDate) throws Exception{
		this.cart = cart;
		this.catalogePrices = catalogePrices;
		this.aCreditCard = aCreditCard;
		if(this.cart.isEmpty() || this.catalogePrices.isEmpty() || this.aCreditCard.validate(currentDate)) {
			throw new Exception("Carro de compras vacio o Precios vacio");
		}
	}

	public Cashier(Cart cart, HashMap<Book, Double> catalogePrices, CreditCard aCreditCard, LocalDate currentDate, MerchantPass merchantPass) throws Exception{
		this.cart = cart;
		this.catalogePrices = catalogePrices;
		this.aCreditCard = aCreditCard;
		this.merchantPass = merchantPass;
		if(this.cart.isEmpty() || this.catalogePrices.isEmpty() || this.aCreditCard.validate(currentDate)) {
			throw new Exception("Carro de compras vacio o Precios vacio");
		}
	}

	public Boolean isEmptyCart() {
		return this.cart.isEmpty();
	}

	public Double calculateAmmount() {
		Double ammount = 0.0;
		for (Item item : cart.getItems()) {
			ammount += getPrice(item.getBook()) * item.getQuantity();
		}
		return ammount;
		
	}

	private Double getPrice(Book book) {
		Double amount = 0.0;
		for (Map.Entry<Book, Double> set :
            catalogePrices.entrySet()) {

			if(set.getKey().equals(book)) {
				amount = set.getValue();
			}
       }
		return amount;
	}

	public MerchantPass getMerchantPass() {
		return merchantPass;
	}

	public void setMerchantPass(MerchantPass merchantPass) {
		this.merchantPass = merchantPass;
	}

}
