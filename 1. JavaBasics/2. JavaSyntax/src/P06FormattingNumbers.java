/* Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), 
 * a floating-point b and a floating-point c and prints them in 4 virtual 
 * columns on the console. Each column should have a width of 10 characters. 
 * The number a should be printed in hexadecimal, left aligned; then the 
 * number a should be printed in binary form, padded with zeroes, then the 
 * number b should be printed with 2 digits after the decimal point, right 
 * aligned; the number c should be printed with 3 digits after the decimal 
 * point, left aligned.  */

import java.util.Scanner;

public class P06FormattingNumbers {

    public static void main(String[] args) {
	System.out.print("a: ");
	Scanner scanner = new Scanner(System.in);
	int a = scanner.nextInt();
	System.out.print("b: ");
	double b = scanner.nextDouble();
	System.out.print("c: ");
	double c = scanner.nextDouble();
	String hexAString = Integer.toHexString(a).toUpperCase();
	String binAString = Integer.toBinaryString(a);
	System.out.println();
	System.out.printf("|%-10s|%010d|%10.2f|%-10.3f|", hexAString,
		Integer.parseInt(binAString), b, c);
    }

}
