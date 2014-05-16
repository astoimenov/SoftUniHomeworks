import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;
import java.util.Scanner;
import java.util.Set;

/* Тук се опитах да направя задачата с Map, но на поседния
 * тест не подрежда резултатите правилно. */

public class P05AngleUnitConverterWithMap {

    public static void main(String[] args) {
	Scanner scanner = new Scanner(System.in);
	double value = 0.0;
	String measure = "";
	Map<Double, String> queries = new HashMap<>();
	int n = scanner.nextInt();
	for (int i = 0; i < n; i++) {
	    value = scanner.nextDouble();
	    measure = scanner.next();
	    queries.put(value, measure);
	}
	Set set = queries.entrySet();
	Iterator it = set.iterator();
	System.out.println();
	while (it.hasNext()) {
	    Map.Entry mapEntry = (Map.Entry) it.next();
	    String mapValue = (String) mapEntry.getValue();
	    if (mapValue.equals("rad")) {
		double valueToDeg = radToDeg((Double) mapEntry.getKey());
		System.out.printf("%.6f\n", valueToDeg);
	    } else if(mapValue.equals("deg")) {
		double valueToRad = degToRad((Double) mapEntry.getKey());
		System.out.printf("%.6f\n", valueToRad);
	    }
	}
    }
    
    private static double degToRad(double deg) {
	double toRad = deg * 0.0174532925;
	return toRad;
    }

    private static double radToDeg(double rad) {
	double toDeg = rad / 0.0174532925;
	return toDeg;
    }
}
