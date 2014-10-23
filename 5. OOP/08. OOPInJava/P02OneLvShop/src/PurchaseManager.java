public final class PurchaseManager {
    public static void ProcessPurchase(Customer customer, Product product) {
	double newBalance = customer.getBalance() - product.getPrice();
	customer.setBalance(newBalance);
	int newQuantity = product.getQuantity() - 1;
	product.setQuantity(newQuantity);

	if (product.getQuantity() == 0) {
	    System.out.println("The product is out of stock!");
	} else if ((product instanceof Expirable)
		&& (((FoodProduct) product).isExpired())) {
	    System.out.println("The product is expired!");
	} else if (customer.getBalance() < product.getPrice()) {
	    System.out
		    .println("You do not have enough money to buy this product!");
	} else if ((product.getAgeRestriction() == AgeRestriction.Adult)
		&& (customer.getAge() < 18)) {
	    System.out.println("You are too young to buy this product!");
	} else {
	    System.out.println("Other!");
	}
    }
}
