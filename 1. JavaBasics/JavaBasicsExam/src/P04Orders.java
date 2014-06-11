import java.util.ArrayList;
import java.util.Collections;
import java.util.Map;
import java.util.Map.Entry;
import java.util.Scanner;
import java.util.Set;
import java.util.TreeMap;

public class P04Orders {

    public static void main(String[] args) {
	Scanner scanner = new Scanner(System.in);
	int n = Integer.parseInt(scanner.nextLine());
	StringBuilder builder = new StringBuilder();
	ArrayList<String> lines = new ArrayList<>();
	for (int i = 0; i < n; i++) {
	    String[] tokens = scanner.nextLine().split(" ");
	    builder.append(tokens[2]).append(" ").append(tokens[0]).append(" ")
		    .append(tokens[1]);
	    lines.add(builder.toString());
	    builder.setLength(0);

	}
	Collections.sort(lines);
	for (String string : lines) {
	    System.out.println(string);
	}
	Map<String, Map<String, Integer>> orders = new TreeMap<>();
	String key1 = "";
	String key2 = "";
	int value = 0;
	for (int i = 0; i < lines.size(); i++) {
	    String[] tokens = lines.get(i).split(" ");
	    key1 = tokens[0];
	    key2 = tokens[1];
	    value = Integer.parseInt(tokens[2]);
	    Map<String, Integer> map = new TreeMap<>();
	    if (orders.containsKey(key1) && map.containsKey(key2)) {
		if (map.containsKey(key2)) {
		    value += map.get(key2);
		} else {
		    map.put(key2, value);
		    orders.put(key1, map);
		}
	    }
	    map.put(key2, value);
	    orders.put(key1, map);

	}

	for (Map.Entry<String, Map<String, Integer>> entry : orders.entrySet()) {
	    System.out.print(entry.getKey() + ": ");
	    for (Map.Entry<String, Integer> ent : orders.get(entry.getKey())
		    .entrySet()) {
		System.out.print(ent.getKey() + " " + ent.getValue());
	    }
	    System.out.println();
	}
    }

}
