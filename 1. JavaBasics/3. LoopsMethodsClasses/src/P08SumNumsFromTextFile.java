import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

/* Write a program to read a text file "Input.txt" holding a 
 * sequence of integer numbers, each at a separate line. Print 
 * the sum of the numbers at the console. Ensure you close 
 * correctly the file in case of exception or in case of normal 
 * execution. In case of exception (e.g. the file is missing), 
 * print "Error" as a result. */

public class P08SumNumsFromTextFile {

    public static void main(String[] args) {
	int sum = 0;
	try (BufferedReader fileReader = new BufferedReader(new FileReader(
		"input.txt"));) {
	    while (true) {
		String line = fileReader.readLine();
		if (line == null) {
		    break;
		}
		sum += Integer.parseInt(line);
	    }
	} catch (IOException e) {
	    System.out.println("Error");
	}
	System.out.println(sum);
    }
}