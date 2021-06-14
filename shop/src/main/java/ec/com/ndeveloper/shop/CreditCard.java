package ec.com.ndeveloper.shop;

import java.time.LocalDate;
import java.time.YearMonth;

public class CreditCard {

	YearMonth expireDate;
	String cardNumber;
	String name;

	public CreditCard(YearMonth expireDate, String cardNumber, String name) {
		this.expireDate = expireDate;
		this.cardNumber = cardNumber;
		this.name = name;
	}

	public boolean validate(LocalDate currentDate) {
		return expireDate.isBefore(YearMonth.from(currentDate));
	}
	
}
