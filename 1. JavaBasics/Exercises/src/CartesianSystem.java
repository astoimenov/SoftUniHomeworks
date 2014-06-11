import java.util.Scanner;

public class CartesianSystem {

    public static void main(String[] args) {
	Scanner scanner = new Scanner(System.in);
	double x = scanner.nextDouble();
	double y = scanner.nextDouble();

	if (x == 0) {
	    if (y == 0) {
		System.out.println(0);
	    } else {
		System.out.println(5);
	    }
	} else if (y == 0) {
	    System.out.println(6);
	} else if (y > 0) {
	    if (x > 0) {
		System.out.println(1);
	    } else {
		System.out.println(2);
	    }
	} else {
	    if (x < 0) {
		System.out.println(3);
	    } else {
		System.out.println(4);
	    }
	}
    }

}
