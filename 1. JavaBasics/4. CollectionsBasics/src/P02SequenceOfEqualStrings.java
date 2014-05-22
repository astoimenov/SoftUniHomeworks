import java.util.Scanner;

/* Write a program that enters an array of strings
 * and finds in it all sequences of equal elements.
 * The input strings are given as a single line,
 * separated by a space.  */

public class P02SequenceOfEqualStrings {

    public static void main(String[] args) {
	Scanner scanner = new Scanner(System.in);
	String line = scanner.nextLine();
	String[] tokens = line.split(" ");
	System.out.print(tokens[0]);
	for (int i = 1; i < tokens.length; i++) {
	    if (tokens[i].equals(tokens[i - 1])) {
		System.out.print(" " + tokens[i]);
	    } else {
		System.out.println();
		System.out.print(tokens[i]);
	    }
	}
    }

}
