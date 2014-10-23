import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;

/**
 * Handles the keyboard events
 * */
public class EventHandler implements KeyListener {

    /**
     * EventHandler constructor
     * @param Game object
     */
    public EventHandler(Game game) {
	game.addKeyListener(this);
    }

    /**
     * Handles a key press
     * @param Key event
     * */
    public void keyPressed(KeyEvent e) {
	int keyCode = e.getKeyCode();

	if (keyCode == KeyEvent.VK_W || keyCode == KeyEvent.VK_UP) {
	    if (Game.snake.getVelY() != 20) {
		Game.snake.setVelX(0);
		Game.snake.setVelY(-20);
	    }
	}
	if (keyCode == KeyEvent.VK_S || keyCode == KeyEvent.VK_DOWN) {
	    if (Game.snake.getVelY() != -20) {
		Game.snake.setVelX(0);
		Game.snake.setVelY(20);
	    }
	}
	if (keyCode == KeyEvent.VK_D || keyCode == KeyEvent.VK_RIGHT) {
	    if (Game.snake.getVelX() != -20) {
		Game.snake.setVelX(20);
		Game.snake.setVelY(0);
	    }
	}
	if (keyCode == KeyEvent.VK_A || keyCode == KeyEvent.VK_LEFT) {
	    if (Game.snake.getVelX() != 20) {
		Game.snake.setVelX(-20);
		Game.snake.setVelY(0);
	    }
	}
	if (keyCode == KeyEvent.VK_ESCAPE) {
	    System.exit(0);
	}
    }

    public void keyReleased(KeyEvent e) {
    }

    public void keyTyped(KeyEvent e) {

    }

}
