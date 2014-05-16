/* Write a program to generate and print all 3-letter words consisting 
 * of given set of characters. The input characters are given as string 
 * at the first line of the input. Input characters are unique (there 
 * are no repeating characters). */

import java.util.Scanner;

public class P02Generate3LetterWords {

    public static void main(String[] args) {
	Scanner scanner = new Scanner(System.in);
	char[] charArr = scanner.next().toCharArray();
	for (char first : charArr) {
	    for (char second : charArr) {
		for (char third : charArr) {
		    System.out.printf("%c%c%c ", first, second, third);
		}
	    }
	}
    }
}
