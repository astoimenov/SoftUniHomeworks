import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Locale;

/* Create a class Product to hold products, which have name (string) 
 * and price (decimal number). Read from a text file named "Products.txt" 
 * a list of product with prices and keep them in a list of products. 
 * Each product will be in format name + space + price. You should hold 
 * the products in objects of class Product. Read from a text file named 
 * "Order.txt" an order of products with quantities. Each order line will 
 * be in format product + space + quantity. Calculate and print in a text 
 * file "Output.txt" the total price of the order. */

public class P10OrderOfProducts {

    public static void main(String[] args) {
	Locale.setDefault(Locale.ROOT);
	ArrayList<Product> products = new ArrayList<>();
	products = readProducts("Products.txt");
	double total = calculateTotlaPrice("Order.txt", products);
	writeToFile(total, "Output.txt");
    }

    private static void writeToFile(double total, String output) {
	try (BufferedWriter out = new BufferedWriter(new FileWriter(output));) {
	    out.write(String.format("%.1f", total));
	} catch (IOException e) {
	    System.out.println("Error");
	}
    }

    private static double calculateTotlaPrice(String fileName,
	    ArrayList<Product> products) {
	double total = 0.0;
	try (BufferedReader fileReader = new BufferedReader(new FileReader(
		fileName));) {
	    while (true) {
		String line = fileReader.readLine();
		if (line == null) {
		    break;
		}
		String[] tokens = line.split(" ");
		for (Product product : products) {
		    if (product.getName().equals(tokens[1])) {
			total += product.getPrice()
				* Double.parseDouble(tokens[0]);
		    }
		}
	    }
	} catch (IOException e) {
	    System.out.println("Error");
	}
	return total;
    }

    private static ArrayList<Product> readProducts(String fileName) {
	ArrayList<Product> productList = new ArrayList<>();
	try (BufferedReader fileReader = new BufferedReader(new FileReader(
		fileName));) {
	    while (true) {
		Product product = new Product();
		String line = fileReader.readLine();
		if (line == null) {
		    break;
		}
		String[] tokens = line.split(" ");
		product.setName(tokens[0]);
		product.setPrice(Double.parseDouble(tokens[1]));
		productList.add(product);
	    }
	} catch (IOException e) {
	    System.out.println("Error");
	}
	return productList;
    }

}
