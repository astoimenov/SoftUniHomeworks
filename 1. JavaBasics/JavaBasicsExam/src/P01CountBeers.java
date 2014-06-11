import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class P01CountBeers {

    public static void main(String[] args) {
	Scanner scanner = new Scanner(System.in);
	Map<String, Integer> inputBeers = new TreeMap<String, Integer>();
	while (scanner.hasNext()) {
	    if (!scanner.next().equals("End")) {
		String[] tokens = scanner.nextLine().split(" ");
		inputBeers.put(tokens[1], Integer.parseInt(tokens[0]));
	    }
	}
	System.out.println();
	for (Map.Entry<String, Integer> entry : inputBeers.entrySet()) {
	    System.out.println(entry.getKey() + " " + entry.getValue());
	}
    }
}
