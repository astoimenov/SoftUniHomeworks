import java.awt.Color;
import java.awt.Graphics;
import java.util.Random;


/**
 * @author me
 * 
 */
public class Apple {
    public static Random random;
    private Point applePoint;
    private Color appleColor;

    public Apple(Snake snake) {
	applePoint = createApple(snake);
	appleColor = Color.RED;
    }

    /**
     * Create apple with random position.
     * @param s Current snake.
     * @return Return point element of type PointOfSnake
     */
    private Point createApple(Snake snake) {
	random = new Random();
	int x = random.nextInt(30) * 20;
	int y = random.nextInt(30) * 20;
	for (Point snakePoint : snake.snakeBody) {
	    if (x == snakePoint.getX() || y == snakePoint.getY()) {
		return createApple(snake);
	    }
	}
	return new Point(x, y);
    }

    /**
     * Draws an apple in the game
     * @param Graphics object
     */
    public void renderApple(Graphics g) {
	applePoint.render(g, appleColor);
    }

    /**
     * Method to get apple's point
     * @param Point 
     */
    public Point getPoint() {
	return applePoint;
    }
}
