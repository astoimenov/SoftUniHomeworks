/* Write a program that enters a positive integer number
 * and converts and prints it in hexadecimal form. */

import java.util.Scanner;

public class P05DecimalToHex {

    public static void main(String[] args) {
	System.out.print("input: ");
	Scanner scanner = new Scanner(System.in);
	int decNumber = scanner.nextInt();
	String hexNumberString = Integer.toHexString(decNumber);
	System.out.println();
	System.out.println(hexNumberString.toUpperCase());

    }

}
