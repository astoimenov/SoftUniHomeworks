import java.awt.Color;
import java.awt.Graphics;

/**
 * @author Alexander
 * 
 */
public class Point {
    private int x, y;
    private final int Width = 20;
    private final int Height = 20;

    public Point(Point p) {
	this(p.x, p.y);
    }

    public Point(int x, int y) {
	this.x = x;
	this.y = y;
    }

    public int getX() {
	return x;
    }

    public void setX(int x) {
	this.x = x;
    }

    public int getY() {
	return y;
    }

    public void setY(int y) {
	this.y = y;
    }

    /*
     * @para
     */
    public void render(Graphics g, Color cvqt) {
	g.setColor(Color.BLACK);
	g.fillRect(x, y, Width, Height);
	g.setColor(cvqt);
	g.fillRect(x + 1, y + 1, Width - 2, Height - 2);
    }

    public String toString() {
	return "[x=" + x + ",y=" + y + "]";
    }

    /**
     * Compares if two points are equal
     * */
    public boolean equals(Object object) {
	if (object instanceof Point) {
	    Point point = (Point) object;
	    return (x == point.x) && (y == point.y);
	}
	return false;
    }
}
