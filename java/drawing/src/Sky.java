// Kyra Thomas
// 10/29/2023
// Drawing

import javax.swing.*;
import java.awt.*;
import java.awt.geom.GeneralPath;

public class Sky extends JPanel {
    private int x;
    private int y;
    private int width;
    private int height;

    // initial value constructor
    public Sky(int x, int y, int width, int height)
    {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
    }

    // default constructor
    public Sky()
    {
        x = 600;
        y = 100;
        width = 100;
        height = 100;

    }

    @Override
    public void paintComponent(Graphics g)
    {
        Graphics2D g2d = (Graphics2D) g.create();

        // color variables
        Color skyBlue = new Color(135, 206, 235);
        Color yellow = new Color(250, 253, 15);
        Color sunsetPink = new Color(180, 71, 184);

        // gradient
        GradientPaint blueToPink = new GradientPaint(0,0,skyBlue,0, getHeight(), sunsetPink);

        // fills background with sky blue
        g2d.setPaint(blueToPink);
        g2d.fillRect(0, 0, getWidth(), getHeight());

        // Draws the sun
        g.setColor(yellow);
        g.fillOval(x, y, width, height);

        // draws the mountains
        for (int i = 0; i < 6; i++) {
            GeneralPath mountain1 = new GeneralPath();
            int[] mountain1x = {0 + (i * 150), 200 + (i * 150), 400 + (i * 150)};
            int[] mountain1y = {getHeight(), (getHeight() / 2), getHeight()};
            g2d.setPaint(Color.black);
            mountain1.moveTo(mountain1x[0], mountain1y[0]);
            for (int k = 0; k < mountain1y.length; k++) {
                mountain1.lineTo(mountain1x[k], mountain1y[k]);
            }
            mountain1.closePath();
            g2d.fill(mountain1);
        }

        //GeneralPath mountain2 = new GeneralPath();
        //int[] mountain2x = {100, 300, 500};
        //int[] mountain2y = {getHeight(), (getHeight() / 2), getHeight()};
        //g2d.setPaint(Color.black);
        //mountain2.moveTo(mountain2x[0], mountain2y[0]);
        //for (int k = 0; k < mountain2y.length; k++) {
        //    mountain2.lineTo(mountain2x[k], mountain2y[k]);
        //}
        //mountain2.closePath();
        //g2d.fill(mountain2);
        g2d.dispose();
    }

    public static void main(String[] args) {
        JPanel sky = new Sky();
        JFrame frame = new JFrame("Sky");
        frame.add(sky);
        frame.pack();
        frame.setSize(new Dimension(1200,350));
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setVisible(true);
    }
}