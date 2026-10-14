import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        int inputAnswer = 0;
        int difficulty, operation;

        // main loop with main menu for extra credit
        do {
            // initial output and difficulty setting
            System.out.println("NOTE: All operations use integer arithmetic.");
            System.out.print("\nEnter the difficulty level (1 = single digits, 2 = two digits, etc. between 1 and 4): ");

            difficulty = input.nextInt();

            while (difficulty < 1 || difficulty > 4) {
                System.out.print("\nInvalid selection. Enter the difficulty level (1 = single digits, 2 = two digits, etc. between 1 and 4): ");
                difficulty = input.nextInt();
            }

            // main menu
            System.out.println("1. Addition");
            System.out.println("2. Subtraction");
            System.out.println("3. Multiplication");
            System.out.println("4. Division");
            System.out.println("5. Mixed operations");
            System.out.print("Enter the operation: ");
            operation = input.nextInt();

            do {
                int questionCount;
                int correctAnswerCount = 0;

                // loop 10 times per student
                for (questionCount = 0; questionCount < 10; questionCount++) {
                    int correctAnswer;

                    // prompt with question and generate correct answer
                    correctAnswer = generateQuestion(difficulty, operation);

                    // loop until correct answer is input
                    // get answer
                    System.out.print("Enter your answer (-1 to exit.) ");
                    inputAnswer = input.nextInt();

                    if (inputAnswer == -1)
                        break;

                    // if answer is correct
                    if (inputAnswer == correctAnswer) {
                        System.out.println(answerResponse(true));
                        correctAnswerCount++;
                    }

                    // if answer is incorrect, loop until it is
                    else {
                        while (inputAnswer != correctAnswer) {
                            System.out.println(answerResponse(false));
                            inputAnswer = input.nextInt();
                        }
                    }
                }
                if (inputAnswer == -1)
                    break;
                else
                    // after the student has answered 10 questions
                    System.out.println(finalizeQuiz(correctAnswerCount, questionCount));
            } while (inputAnswer != -1);
        } while (inputAnswer != -1);
    }

    // method 1 - Generates the question
    public static int generateQuestion(int digitCount, int operationType) {
        // generate 2 random ints
        int digit1 = (int)(Math.random() * (Math.pow(10, digitCount)));
        int digit2 = (int)(Math.random() * (Math.pow(10, digitCount)));

        // get a random case number if the operation type is 5
        if (operationType == 5)
            operationType = (int)(Math.random() * 4) + 1;

        switch (operationType) {
            // addition
            case 1: {
                System.out.println("How much is " + digit1 + " plus " + digit2 + "?");
                return digit1 + digit2;
            }

            // subtraction
            case 2: {
                int newDigit1, newDigit2;

                // make sure the first digit is the largest first
                if (digit1 > digit2) {
                    newDigit1 = digit1;
                    newDigit2 = digit2;
                }
                else {
                    newDigit1 = digit2;
                    newDigit2 = digit1;
                }

                System.out.println("How much is " + newDigit1 + " minus " + newDigit2 + "?");
                return newDigit1 - newDigit2;
            }

            // multiplication
            case 3: {
                System.out.println("How much is " + digit1 + " times " + digit2 + "?");
                return digit1 * digit2;
            }

            // division
            case 4: {
                // make sure the first digit is the largest first
                int newDigit1, newDigit2;

                if (digit1 > digit2) {
                    newDigit1 = digit1;
                    newDigit2 = digit2;
                }
                else {
                    newDigit1 = digit2;
                    newDigit2 = digit1;
                }

                // make sure there is no 0 in the division
                if (newDigit2 == 0)
                    newDigit2++;

                System.out.println("How much is " + newDigit1 + " divided by " + newDigit2 + "?");
                return newDigit1 / newDigit2;
            }
        }
    return 0;       // necessary default
    }

    // method 2 - Generates a random response depending on if answer was correct or not.
    public static String answerResponse(boolean answerIsCorrect) {
        // get random number between 1 and 4
        // I had to look up how to do this, I hope this is okay.
        int response = (int)(Math.random() * (4 - 1) + 1);

        // if answer is correct
        if (answerIsCorrect) {
            switch (response) {
                case 1:
                    return "Very good!";
                case 2:
                    return "Excellent!";
                case 3:
                    return "You must have practiced a lot!";
                case 4:
                    return "Keep up the good work!";
            }
        }

        // if answer is incorrect
        else {
            switch (response) {
                case 1:
                    return "Please try again.";
                case 2:
                    return "Incorrect. Keep practicing.";
                case 3:
                    return "Don't give up. Try again.";
                case 4:
                    return "Give it another shot.";
            }
        }

        // this seems necessary to avoid an error, but I think it will be overridden
        return "";
    }

    // method 3 - Finishes the quiz and calculates score and response
    public static String finalizeQuiz (int correct, int total) {
        double percentage;

        // calculate percentage
        percentage = ((double)correct / total) * 100;

        // return string
        // if the percentage is above 75%
        if (percentage > 74)
            return "Score: " + percentage + "%.\nCongratulations, you are ready to go to the next level!";
        else
            return "Score: " + percentage + "%.\nPlease ask your teacher for extra help.";
    }
}