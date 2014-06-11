import java.util.Scanner;

public class P03WineGlass {

    public static void main(String[] args) {
	Scanner scanner = new Scanner(System.in);
	int n = scanner.nextInt();
	for (int i = 0; i < n / 2; i++) {
	    String dotsString = newString('.', i);
	    String starsString = newString('*', n - 2 * (i + 1));
	    System.out.printf("%s\\%s/%1$s", dotsString, starsString).println();
	}
	if (n < 12) {
	    printStool(n, n / 2 - 1);
	} else {
	    printStool(n, n / 2 - 2);
	}
    }

    private static void printStool(int n, int reps) {
	for (int i = 0; i < n / reps; i++) {
	    String dotsString = newString('.', (n - 2) / 2);
	    System.out.printf("%s||%1$s", dotsString).println();
	}
    }

    public static String newString(char ch, int size) {
	return new String(new char[size]).replace('\0', ch);
    }

}
