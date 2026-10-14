import javax.swing.*;
import javax.swing.border.Border;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.security.SecureRandom;

class HangmanPanel extends JPanel implements ActionListener {
    private JButton clickButton;
    private JTextField enterText;
    private JPanel controlPanel;

    // declare class-level member variables here
    private int count = 0;
    private int countWrong = 0;
    private int countRight = 0;
    private String[] words = {"AWKWARD", "MATRIX", "ONYX", "QUIZZES", "EMBEZZLE", "STRONGHOLD", "QUEUE", "IVY", "OXYGEN", "MICROWAVE"};
    private String word;
    String input = "";
    String message = "Fill in Letters";

    // this is the string of characters to place above the lines. will be initialized
    // to spaces and filled in as the game progresses
    String displayString;

    public HangmanPanel() {
        setLayout(new BorderLayout());
        controlPanel = new JPanel();
        clickButton = new JButton("Click Me!");
        clickButton.addActionListener(this);
        enterText = new JTextField();
        controlPanel.setLayout(new BoxLayout(controlPanel, BoxLayout.X_AXIS));
        controlPanel.add(enterText);
        controlPanel.add(clickButton);
        controlPanel.setPreferredSize(new Dimension(600, 50));
        add(controlPanel, BorderLayout.PAGE_END);
        word = words[new SecureRandom().nextInt(words.length)];
        displayString = " ".repeat(word.length());
    }

    @Override
    public void paintComponent(Graphics g)
    {
        Graphics2D g2D = (Graphics2D) g;
        g2D.setColor(Color.black);
        Font c = new Font("Courier", Font.PLAIN, 48);       // it isn't displaying as Courier
        g2D.setFont(c);
        g2D.drawString("Hangman Game", 130, 40);

        // draw gallows method
        drawGallows(g2D);

        // draw each part of the hangman
        // use a switch statement based on countWrong
        // use custom methods similar to example and call relevant for each case
        // use the fall through effect of the switch statement
        drawHangman(g2D, countWrong);

        drawLines(g2D);
        g2D.drawString(message, 10, 36);

        if (input.length() > 1) {
            if (input.equals(word))
                message = "You win!";
            else
                message = "You lose";
            displayString = word;
            clickButton.setLabel("New Game");
        }

        else if (input.length() == 1) {
            // single letter guess
            char[] wordArray = word.toUpperCase().toCharArray();
            char[] displayStringArray = displayString.toUpperCase().toCharArray();
            char inputChar = input.toUpperCase().charAt(0);

            boolean letterFound = false;
            for (int i = 0; i < wordArray.length; i++) {
                if (inputChar == wordArray[i]) {
                    displayStringArray[i] = inputChar;
                    letterFound = true;
                }
            }

            if (letterFound) {
                countRight++;
            }
            else {
                countWrong++;
                drawHangman(g2D, countWrong);
            }

            displayString = new String(displayStringArray);

            if (displayString.equals(word)) {
                message = "You win!";
                clickButton.setLabel("New Game");
            }
        }

        for (int i = 0; i < displayString.length(); i++) {
            drawLetter(g2D, i);
        }
    }

    // this happens when button is clicked
    @Override
    public void actionPerformed(ActionEvent e) {
        if (word.equals(displayString)) {
            countRight = 0;
            countWrong = 0;
            clickButton.setLabel("Guess");
            word = words[new SecureRandom().nextInt(words.length)];
            displayString = " ".repeat(word.length());
            message = "Fill in Letters";
            input = "";
        }

        input = enterText.getText().toUpperCase();
        enterText.setText("");
        enterText.requestFocus();

        // I think this specifically is not working
        repaint();

        if (countWrong == 6)
            countWrong = 0;
        if (countRight == word.length()) {
            countRight = 0;
        }
        count++;
    }

    // custom methods
    // drawing the gallows
    public void drawGallows(Graphics2D g2D)
    {
        g2D.setColor(Color.black);
        g2D.fillRect(10, 630, 100, 10);
        g2D.fillRect(55, 150, 10, 480);
        g2D.fillRect(55, 140, 215, 10);
        g2D.fillRect(260, 150, 10, 30);
    }

    //add code to draw each body part or parts
    //based on the value of count, I would
    //use a switch statement with the fall through effect
    public void drawHangman(Graphics2D g2D, int i) {
        switch (i) {
            case (6): {
                drawRightLeg(g2D);
            }
            case (5): {
                drawLeftLeg(g2D);
            }
            case (4): {
                drawRightArm(g2D);
            }
            case (3): {
                drawLeftArm(g2D);
            }
            case (2): {
                drawBody(g2D);
            }
            case (1): {
                drawHead(g2D);
            }
        }
    }

    public void drawHead(Graphics2D g2D) {
        g2D.setStroke(new BasicStroke(3.0f));
        g2D.setColor(Color.RED);
        g2D.fillOval(240, 180, 50, 50);
    }

    public void drawBody(Graphics2D g2D) {
        g2D.fillRect(260, 230, 10, 100);
    }

    public void drawLeftArm(Graphics2D g2D) {
        BasicStroke lineStroke = new BasicStroke(10);
        g2D.setStroke(lineStroke);
        g2D.drawLine(230, 230, 260, 280);
    }

    public void drawRightArm(Graphics2D g2D) {
        BasicStroke lineStroke = new BasicStroke(10);
        g2D.setStroke(lineStroke);
        g2D.drawLine(300, 230, 270, 280);
    }

    public void drawLeftLeg(Graphics2D g2D) {
        BasicStroke lineStroke = new BasicStroke(10);
        g2D.setStroke(lineStroke);
        g2D.drawLine(230, 430, 260, 320);
    }

    public void drawRightLeg(Graphics2D g2D) {
        BasicStroke lineStroke = new BasicStroke(10);
        g2D.setStroke(lineStroke);
        g2D.drawLine(300, 430, 270, 320);
    }

    public void drawLines(Graphics2D g2D) {
        g2D.setColor(Color.BLACK);
        g2D.setStroke(new BasicStroke(3.0f));
        for (int i = 0; i < word.length(); i++) {
            g2D.drawLine((i * 50 + 80), 550, (i * 50 + 110), 550);
        }
    }

    public void drawLetter(Graphics2D g2D, int i) {
        g2D.drawString(String.valueOf(displayString.charAt(i)), (i * 50 + 60), 550);
    }
}

//Class with the main method that launches the frame
//You don't need to change code below other than preferred sizes.
public class Main {
    public static void main(String[] args) {
        EventQueue.invokeLater(new Runnable() {
            @Override
            public void run() {
                JFrame frame = new HangmanGameFrame();
                frame.setTitle("Hangman Part I");
                frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
                frame.setVisible(true);
            }
        });
    }
}

class HangmanGameFrame extends JFrame {
    public HangmanGameFrame() {
        HangmanPanel panel = new HangmanPanel();
        panel.setPreferredSize(new Dimension(600, 700));
        add(panel);
        pack();
    }
}