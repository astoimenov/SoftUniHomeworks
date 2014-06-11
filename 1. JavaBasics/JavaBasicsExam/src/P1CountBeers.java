import java.util.Scanner;

public class P1CountBeers {

    public static void main(String[] args) {
	Scanner scanner = new Scanner(System.in);
	int beersCount = 0;
	int stacksCount = 0;
	while (!scanner.equals("End")) {
	    String[] tokens = scanner.nextLine().split(" ");
	    if (tokens[0].equals("End")) {
		break;
	    }
	    if (tokens[1].equals("beers")) {
		beersCount += Integer.parseInt(tokens[0]);
	    } else {
		stacksCount += Integer.parseInt(tokens[0]);
	    }
	}
	if (beersCount >= 20) {
	    stacksCount += beersCount / 20;
	    beersCount %= 20;
	}
	System.out.printf("%1$d stacks + %2$d beers", stacksCount, beersCount);
    }

}
