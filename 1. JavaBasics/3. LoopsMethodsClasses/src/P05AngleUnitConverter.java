import java.util.ArrayList;
import java.util.Scanner;

/* Write a method to convert from degrees to radians. Write a method
 * to convert from radians to degrees. You are given a number n and
 * n queries for conversion. Each conversion query will consist of
 * a number + space + measure. Measures are "deg" and "rad". Convert
 * all radians to degrees and all degrees to radians. Print the
 * results as n lines, each holding a number + space + measure. Format
 * all numbers with 6 digit after the decimal point. */

public class P05AngleUnitConverter {

    public static void main(String[] args) {
	ArrayList<Double> convertedList = new ArrayList<>();
	Scanner scanner = new Scanner(System.in);
	int n = scanner.nextInt();
	for (int i = 0; i < n; i++) {
	    double value = scanner.nextDouble();
	    String measure = scanner.next();
	    convertedList.add(unitConverter(value, measure));
	}
	System.out.println();
	for (Double converted : convertedList) {
	    System.out.printf("%.6f\n", converted);
	}
    }

    private static double unitConverter(double value, String measure) {
	if (measure.equals("rad"))
	    return Math.toDegrees(value);
	else
	    return Math.toRadians(value);
    }
}