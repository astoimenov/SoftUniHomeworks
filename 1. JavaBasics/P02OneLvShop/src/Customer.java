public class Customer {
    private String name = "customer";
    private int age;
    private double balance;

    public Customer(String name, int age, double balance) {
	this.setName(name);
	this.setAge(age);
	this.setBalance(balance);
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

    public int getAge() {
	return age;
    }

    public void setAge(int age) throws IllegalArgumentException {
	if (this.age < 0) {
	    throw new IllegalArgumentException("The age can't be negative!");
	}

	this.age = age;
    }

    public double getBalance() {
	return balance;
    }

    public void setBalance(double balance) {
	this.balance = balance;
    }
}
