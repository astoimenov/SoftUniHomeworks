import java.util.ArrayList;
import java.util.Scanner;

public class Proba {

    public static void main(String[] args) {
	Scanner scanner = new Scanner(System.in);
	ArrayList<Character> firstList = new ArrayList<>();
	ArrayList<Character> secondList = new ArrayList<>();
	for (char character : scanner.nextLine().toCharArray()) {
	    firstList.add(character);
	}
	for (char character : scanner.nextLine().toCharArray()) {
	    secondList.add(character);
	}
	secondList.removeAll(firstList);
	firstList.addAll(secondList);
	for (char character : firstList) {
	    System.out.print(character);
	}
    }

}
