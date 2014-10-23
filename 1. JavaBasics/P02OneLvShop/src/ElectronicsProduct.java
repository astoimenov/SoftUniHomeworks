public abstract class ElectronicsProduct extends Product {

    protected int guaranteePeriod;

    public ElectronicsProduct(String name, double price, int quantity,
	    AgeRestriction ageRestriction) {
	super(name, price, quantity, ageRestriction);
	this.setGuaranteePeriod(guaranteePeriod);
    }

    public int getGuaranteePeriod() {
	return guaranteePeriod;
    }

    public void setGuaranteePeriod(int guaranteePeriod) {
	if (this.guaranteePeriod < 0) {
	    throw new IllegalArgumentException("The period can't be negative!");
	}

	this.guaranteePeriod = guaranteePeriod;
    }
}
