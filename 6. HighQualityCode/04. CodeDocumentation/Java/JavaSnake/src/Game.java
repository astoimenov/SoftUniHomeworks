import java.awt.Canvas;
import java.awt.Dimension;
import java.awt.Graphics;

@SuppressWarnings("serial")
public class Game extends Canvas implements Runnable {
    public static Snake snake;
    public static Apple apple;
    static int points;

    private Graphics globalGraphics;
    private Thread runThread;
    public static final int WIDTH = 600;
    public static final int HEIGHT = 600;
    private final Dimension gameDimension = new Dimension(WIDTH, HEIGHT);

    static boolean gameRunning = false;

    /**
     * Draws the game board 
     * */
    public void paint(Graphics g) {
	this.setPreferredSize(gameDimension);
	globalGraphics = g.create();
	points = 0;

	if (runThread == null) {
	    runThread = new Thread(this);
	    runThread.start();
	    gameRunning = true;
	}
    }

    /**
     * Runs the game
     * */
    public void run() {
	while (gameRunning) {
	    snake.tick();
	    render(globalGraphics);
	    try {
		Thread.sleep(100);
	    } catch (InterruptedException e) {
		e.printStackTrace();
	    }
	}
    }

    /**
     * Game constructor
     * */
    public Game() {
	snake = new Snake();
	apple = new Apple(snake);
    }

    /**
     * Renders the game
     * */
    public void render(Graphics g) {
	g.clearRect(0, 0, WIDTH, HEIGHT + 25);

	g.drawRect(0, 0, WIDTH, HEIGHT);
	snake.renderSnake(g);
	apple.renderApple(g);
	g.drawString("score= " + points, 10, HEIGHT + 25);
    }
}
