/* Write a program to calculate the count of bits 1 
 * in the binary representation of given integer number n. */

import java.util.Scanner;

public class P07CountOfBitsOne {

    public static void main(String[] args) {
	System.out.print("n: ");
	Scanner scanner = new Scanner(System.in);
	int n = scanner.nextInt();
	int count = Integer.bitCount(n);
	System.out.println();
	System.out.printf("count: %d", count);
    }

}
