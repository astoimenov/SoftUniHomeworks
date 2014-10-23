public abstract class Product implements Buyable {
    protected String name = "product";
    protected double price;
    protected int quantity;
    protected AgeRestriction ageRestriction;

    public Product(String name, double price, int quantity,
	    AgeRestriction ageRestriction) {
	this.setName(name);
	this.setPrice(price);
	this.setQuantity(quantity);
	this.setAgeRestriction(ageRestriction);
    }

    public String getName() {
	return name;
    }

    public void setName(String name) throws IllegalArgumentException {
	if (this.name.isEmpty()) {
	    throw new IllegalArgumentException("The name can't be empty!");
	}

	this.name = name;
    }

    public double getPrice() {
	return price;
    }

    public void setPrice(double price) throws IllegalArgumentException {
	if (this.price < 0) {
	    throw new IllegalArgumentException("The price can't be negative!");
	}

	this.price = price;
    }

    public int getQuantity() {
	return quantity;
    }

    public void setQuantity(int quantity) throws IllegalArgumentException {
	if (this.quantity < 0) {
	    throw new IllegalArgumentException(
		    "The quantity can't be negative!");
	}

	this.quantity = quantity;
    }

    public AgeRestriction getAgeRestriction() {
	return ageRestriction;
    }

    public void setAgeRestriction(AgeRestriction ageRestriction) {
	this.ageRestriction = ageRestriction;
    }
}
