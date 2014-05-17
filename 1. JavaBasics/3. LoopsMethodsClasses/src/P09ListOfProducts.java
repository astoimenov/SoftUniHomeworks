import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Collections;

/* Create a class Product to hold products, which have name (string) and 
 * price (decimal number). Read from a text file named "Input.txt" a 
 * list of products. Each product will be in format name + space + price. 
 * You should hold the products in objects of class Product. Sort the 
 * products by price and write them in format price + space + name in a 
 * file named "Output.txt". */

public class P09ListOfProducts {

    public static void main(String[] args) {
	try (BufferedReader fileReader = new BufferedReader(new FileReader(
		"input.txt"));) {
	    ArrayList<Product> productList = new ArrayList<>();

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
	    Collections.sort(productList);
	    for (Product pro : productList) {
		System.out.printf("%.2f %s\n", pro.getPrice(), pro.getName());
	    }
	} catch (IOException e) {
	    System.out.println("Error");
	}
    }

}
