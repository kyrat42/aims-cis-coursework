// Kyra Thomas
// 9/19/2023
// Global Warming Facts Quiz

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        // main program loop - use do-while
        char takeAgain = 'Y';

        do {
            // declarations - correct answers count
            int correctAnswers = 0;
            final char ANSWER1 = 'T', ANSWER4 = 'F', ANSWER5 = 'T';
            final int ANSWER2 = 1, ANSWER3 = 3;
            char responseChar;
            int responseInt;

            // intro
            System.out.println("     ----Global Warming Quiz----");

            // question 1
            System.out.println("\n\nTrue or false:");
            System.out.println("The number of record high temperature events in the United States");
            System.out.println("has been increasing while the number of record low temperature");
            System.out.println("events has been decreasing.");

            // answer
            System.out.print("Enter your selection (T/F): ");
            responseChar = input.next().charAt(0);

            // validation
            while (responseChar != 'T' && responseChar != 'F')
            {
                System.out.print("Try again. Enter your selection (T/F): ");
                responseChar = input.next().charAt(0);
            }

            // result - update correct answers
            if (responseChar == ANSWER1)
            {
                System.out.println("Correct!");
                correctAnswers++;
            }
            else
                System.out.println("Incorrect.");

            // question 2
            System.out.println("\n\nWhich of the following are symptoms of climate change?");
            System.out.println("1. Increased flooding");
            System.out.println("2. Decreased tropical storms");
            System.out.println("3. Global temperatures neither increasing nor decreasing");
            System.out.println("4. All of the above");

            // answer
            System.out.print("Enter your selection (1-4): ");
            responseInt = input.nextInt();

            // validation
            while (responseInt < 1 || responseInt > 4)
            {
                System.out.print("Try again. Enter your selection (1-4): ");
                responseInt = input.nextInt();
            }

            // result - update correct answers
            if (responseInt == ANSWER2)
            {
                System.out.println("Correct!");
                correctAnswers++;
            }
            else
                System.out.println("Incorrect.");

            // question 3
            System.out.println("\n\nWhich of the following are benefits of global warming?");
            System.out.println("1. Global temperatures will continue to rise over time.");
            System.out.println("2. Precipitation patterns will change.");
            System.out.println("3. The growing season will lengthen.");
            System.out.println("4. The U.S. sea levels will likely rise.");

            // answer
            System.out.print("Enter your selection (1-4): ");
            responseInt = input.nextInt();

            // validation
            while (responseInt < 1 || responseInt > 4)
            {
                System.out.print("Try again. Enter your selection (1-4): ");
                responseInt = input.nextInt();
            }

            // result - update correct answers
            if (responseInt == ANSWER3)
            {
                System.out.println("Correct!");
                correctAnswers++;
            }
            else
                System.out.println("Incorrect.");

            // question 4
            System.out.println("\n\nTrue or false:");
            System.out.println("Human activity has not contributed to the rise in greenhouse");
            System.out.println("gasses in the atmosphere.");

            // answer
            System.out.print("Enter your selection (T/F): ");
            responseChar = input.next().charAt(0);

            // validation
            while (responseChar != 'T' && responseChar != 'F')
            {
                System.out.print("Try again. Enter your selection (T/F): ");
                responseChar = input.next().charAt(0);
            }

            // result - update correct answers
            if (responseChar == ANSWER4)
            {
                System.out.println("Correct!");
                correctAnswers++;
            }
            else
                System.out.println("Incorrect.");

            // question 5
            System.out.println("\n\nTrue or false:");
            System.out.println("True or false: Humans have the ability to adapt to climate change.");

            // answer
            System.out.print("Enter your selection (T/F): ");
            responseChar = input.next().charAt(0);

            // validation
            while (responseChar != 'T' && responseChar != 'F')
            {
                System.out.print("Try again. Enter your selection (T/F): ");
                responseChar = input.next().charAt(0);
            }

            // result - update correct answers
            if (responseChar == ANSWER5)
            {
                System.out.println("Correct!");
                correctAnswers++;
            }
            else
                System.out.println("Incorrect.");

            // give results, take again?
            if (correctAnswers == 5)
                System.out.println("Excellent");
            else if (correctAnswers == 4)
                System.out.println("Very good");
            else
                System.out.println("Time to brush up on your knowledge of global warming");

            System.out.print("\n\nWould you like to take the quiz again? (Y/N) ");
            takeAgain = input.next().charAt(0);

        } while (takeAgain == 'Y');
    }
}