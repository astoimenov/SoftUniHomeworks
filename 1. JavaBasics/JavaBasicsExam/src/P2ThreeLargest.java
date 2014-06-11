import java.math.BigDecimal;
import java.math.BigInteger;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.Locale;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class P2ThreeLargest {

    public static void main(String[] args) {
	Locale.setDefault(Locale.ROOT);
	Scanner input = new Scanner(System.in);
	int n = input.nextInt();
	input.nextLine();
	BigDecimal[] nums = new BigDecimal[n];
	for (int i = 0; i < nums.length; i++) {
	    String num = input.nextLine();
	    nums[i] = new BigDecimal(num);
	}
	Arrays.sort(nums);
	int count = 3;
	for (int i = nums.length - 1; i >= 0 && count > 0; i--, count--) {
	    System.out.println(nums[i].toPlainString());
	}
    }

}
