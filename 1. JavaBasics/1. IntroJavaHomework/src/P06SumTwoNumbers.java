import java.util.Scanner;

public class P06SumTwoNumbers {
    public static void main(String[] args) {
	Scanner scanner = new Scanner(System.in);
	System.out.print("a: ");
	int a = scanner.nextInt();
	System.out.print("b: ");
	int b = scanner.nextInt();
	int result = a + b;
	System.out.println();
	System.out.println(result);
	scanner.close();

    }
}