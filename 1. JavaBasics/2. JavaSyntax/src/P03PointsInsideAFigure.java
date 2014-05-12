/* Write a program to check whether a point is inside or outside of the 
 * figure below. The point is given as a pair of floating-point numbers, 
 * separated by a space. Your program should print "Inside" or "Outside". */

import java.awt.Rectangle;
import java.awt.geom.Rectangle2D;
import java.util.Scanner;

public class P03PointsInsideAFigure {

    public static void main(String[] args) {
	Rectangle2D firstRectangle = new Rectangle();
	firstRectangle.setFrame(12.5, 6, 10, 2.5);
	Rectangle2D secondRectangle = new Rectangle();
	secondRectangle.setFrame(12.5, 8.5, 5, 5);
	Rectangle2D thirdRectangle = new Rectangle();
	thirdRectangle.setFrame(20, 8.5, 2.5, 5);
	Scanner scanner = new Scanner(System.in);
	double x = scanner.nextDouble();
	double y = scanner.nextDouble();
	if (firstRectangle.contains(x, y) || secondRectangle.contains(x, y)
		|| thirdRectangle.contains(x, y)) {
	    System.out.println("Inside");
	} else {
	    System.out.println("Outside");
	}
    }

}
