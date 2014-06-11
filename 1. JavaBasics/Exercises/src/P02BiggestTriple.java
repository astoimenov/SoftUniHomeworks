import java.util.Scanner;

public class P02BiggestTriple {

    public static void main(String[] args) {
	Scanner scanner = new Scanner(System.in);
	String[] numbersAsStrings = scanner.nextLine().split(" ");
	int[] nums = new int[numbersAsStrings.length];
	for (int i = 0; i < numbersAsStrings.length; i++) {
	    nums[i] = Integer.parseInt(numbersAsStrings[i]);
	}
	int currentSum = 0;
	int currentSubLenght = 0;
	int bestSubLenght = 0;
	int bestStart = 0;
	int bestSum = Integer.MIN_VALUE;
	for (int i = 0; i < nums.length; i += 3) {
	    currentSum = nums[i];
	    currentSubLenght = 1;
	    if (i + 1 < nums.length) {
		currentSum += nums[i + 1];
		currentSubLenght++;
	    }
	    if (i + 2 < nums.length) {
		currentSum += nums[i + 2];
		currentSubLenght++;
	    }
	    if (currentSum > bestSum) {
		bestStart = i;
		bestSum = currentSum;
		bestSubLenght = currentSubLenght;
	    }
	}

	for (int i = bestStart; i < bestSubLenght + bestStart; i++) {
	    System.out.print(nums[i] + " ");
	}
    }

}
