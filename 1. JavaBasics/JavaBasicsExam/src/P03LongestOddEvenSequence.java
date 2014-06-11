import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

public class P03LongestOddEvenSequence {

    public static void main(String[] args) {
	Scanner scanner = new Scanner(System.in);
	String inputLine = scanner.nextLine();
	String[] numbers = inputLine.split("[ ()]+");
	int[] nums = new int[numbers.length-1];
	for (int i = 0; i < nums.length; i++) {
		nums[i] = Integer.parseInt(numbers[i+1]);
	}
	int currentLenght = 1;
	ArrayList<Integer> lenghts = new ArrayList<>();
	for (int i = 1; i < numbers.length - 1; i++) {
	    if (nums[i - 1] % 2 == 0) {
		if (nums[i] % 2 != 0 || nums[i] == 0) {
		    currentLenght++;
		} else {
		    lenghts.add(currentLenght);
		    currentLenght = 1;
		}
	    } else {
		if (nums[i] % 2 == 0 || nums[i] == 0) {
		    currentLenght++;
		} else {
		    lenghts.add(currentLenght);
		    currentLenght = 1;
		}
	    }
	    lenghts.add(currentLenght);
	}
	Collections.sort(lenghts);
	for (int i = lenghts.size() - 1; i > lenghts.size() - 2; i--) {
	    System.out.println(lenghts.get(i));
	}
    }
}
