import java.util.Locale;
import java.util.Scanner;

public class P01FruitMarket {

    public static void main(String[] args) {
	Scanner scanner = new Scanner(System.in);
	String dayOfWeek = scanner.nextLine();
	String[] products = new String[3];
	double[] quantities = new double[3];
	for (int i = 0; i < 3; i++) {
	    quantities[i] = Double.parseDouble(scanner.nextLine());
	    products[i] = scanner.nextLine();
	}

	double totalSum = 0;
	for (int i = 0; i < 3; i++) {
	    totalSum += calculateSum(dayOfWeek, products[i], quantities[i]);
	}
	System.out.printf("%.2f", totalSum);
    }

    private static double calculateSum(String dayOfWeek, String product,
	    double quantity) {
	Locale.setDefault(Locale.ROOT);
	double price = 0.0;
	boolean isFruit = false;
	switch (product) {
	case "banana":
	    price = 1.8;
	    isFruit = true;
	    break;
	case "orange":
	    isFruit = true;
	    price = 1.6;
	    break;
	case "apple":
	    price = 0.86;
	    isFruit = true;
	    break;
	case "tomato":
	    price = 3.2;
	    break;
	case "cucumber":
	    price = 2.75;
	    break;
	default:
	    break;
	}
	switch (dayOfWeek) {
	case "Monday":
	    break;
	case "Tuesday":
	    if (isFruit) {
		price *= 0.8;
	    }
	    break;
	case "Wednesday":
	    if (!isFruit) {
		price *= 0.9;
	    }
	    break;
	case "Thursday":
	    if (product.equals("banana")) {
		price *= 0.7;
	    }
	    break;
	case "Friday":
	    price *= 0.9;
	    break;
	case "Saturday":
	    break;
	case "Sunday":
	    price *= 0.95;
	    break;
	default:
	    break;
	}
	return price * quantity;
    }

}
