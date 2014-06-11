
import java.util.Arrays;
import java.util.Scanner;



public class SortArrayofStrings {

	public static void main(String[] args) {
	  Scanner scanner = new Scanner(System.in);
	  int n = scanner.nextInt();
	  String[] names = new String[n];
	  for (int i = 0; i < n; i++) {
		  
		  names[i] = scanner.next();
		  
		
	}
	  Arrays.sort(names);
	  for (int i = 0; i < n; i++) {
		  System.out.println(names[i]);
		
	}
      scanner.close();
	}

}
	