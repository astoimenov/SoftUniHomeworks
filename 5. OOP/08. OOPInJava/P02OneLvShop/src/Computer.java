public class Computer extends ElectronicsProduct {

    public Computer(String name, double price, int quantity,
	    AgeRestriction ageRestriction) {
	super(name, price, quantity, ageRestriction);
	this.setGuaranteePeriod(24);
    }

    @Override
    public double getPrice() {
	if (this.quantity > 1000) {
	    return (this.price * 0.95);
	}

	return this.price;
    }
}
