/* Write a program that enters the sides of a rectangle
 * (two integers a and b) and calculates and prints 
 * the rectangle's area.  */

import java.util.Scanner;

public class P01RectangleArea {

    public static void main(String[] args) {
	System.out.print("Input: ");
	Scanner scanner = new Scanner(System.in);
	int a = scanner.nextInt();
	int b = scanner.nextInt();
	int area = a * b;
	System.out.println();
	System.out.println(area);
    }

}
