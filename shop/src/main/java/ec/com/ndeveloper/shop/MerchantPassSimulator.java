package ec.com.ndeveloper.shop;

public class MerchantPassSimulator implements MerchantPass {

	Boolean anAvaible;

	public MerchantPassSimulator(Boolean anAvaible) {
		this.anAvaible = anAvaible;
	}

	@Override
	public Boolean isAvaible() {
		return anAvaible;
	}

}
