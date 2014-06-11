import java.util.Arrays;
import java.util.Scanner;

public class P07SortArraysOfStrings {

    public static void main(String[] args) {
	System.out.print("n: ");
	Scanner scanner = new Scanner(System.in);
	int n = scanner.nextInt();
	String[] strings = new String[n];
	for (int i = 0; i < n; i++) {
	    strings[i] = scanner.next();
	}

	scanner.close();
	System.out.println();
	Arrays.sort(strings);
	for (String string : strings) {
	    System.out.println(string);
	}
    }

}
