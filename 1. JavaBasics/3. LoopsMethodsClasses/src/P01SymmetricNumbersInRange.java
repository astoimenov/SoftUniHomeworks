/* Write a program to generate and print all symmetric numbers
 * in given range [start…end]. A number is symmetric if its digits 
 * are symmetric toward its middle.  */

import java.util.Scanner;

public class P01SymmetricNumbersInRange {

    private static boolean isSymmetric(int n) {
	char[] charArr = Integer.toString(n).toCharArray();
	boolean isSymmetric = true;
	for (int i = 0, j = 1; i < charArr.length; i++, j++) {
	    if (isSymmetric) {
		if (charArr[i] != charArr[charArr.length - j]) {
		    isSymmetric = false;
		}
	    }
	}
	return isSymmetric;
    }

    public static void main(String[] args) {
	Scanner scanner = new Scanner(System.in);
	int start = scanner.nextInt();
	int end = scanner.nextInt();
	for (int i = start; i <= end; i++) {
	    if (isSymmetric(i)) {
		System.out.print(i + " ");
	    }
	}
    }
}
