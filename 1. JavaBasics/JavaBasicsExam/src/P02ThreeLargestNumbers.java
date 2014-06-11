import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Locale;
import java.util.Scanner;

public class P02ThreeLargestNumbers {

    public static void main(String[] args) {
	Locale.setDefault(Locale.ROOT);
	Scanner scanner = new Scanner(System.in);
	int n = Integer.parseInt(scanner.nextLine());
	ArrayList<BigDecimal> numbers = new ArrayList<>();
	for (int i = 0; i < n; i++) {
	    numbers.add(scanner.nextBigDecimal());
	}
	Collections.sort(numbers);
	if (n <= 3) {
	    for (int i = numbers.size() - 1; i >= 0; i--) {
		System.out.println(numbers.get(i).toPlainString());
	    }
	} else {
	    for (int i = numbers.size() - 1; i > numbers.size() - 4; i--) {
		System.out.println(numbers.get(i).toPlainString());
	    }
	}
    }

}
