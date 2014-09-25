import java.awt.BorderLayout;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JTextField;

public class JFramePack {

  public static void main(String[] args) {
    JFrame frame = new JFrame();
    frame.setTitle("My First Swing Application");
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    JLabel heading = new JLabel("Computer components");
    frame.add(heading, BorderLayout.NORTH);
    JLabel labelScreenJLabel = new JLabel("Monitor size[inches]: ");
    frame.add(labelScreenJLabel, BorderLayout.WEST);
    JTextField fieldScreen = new JTextField(10);
    frame.add(fieldScreen, BorderLayout.EAST);
    JLabel labelRamJLabel = new JLabel("RAM[GB]: ");
    frame.add(labelRamJLabel, BorderLayout.WEST);
    JTextField fieldRam = new JTextField(10);
    frame.add(fieldRam, BorderLayout.EAST);
    frame.setSize(400, 400);
    frame.pack();
    frame.setVisible(true);
  }
}