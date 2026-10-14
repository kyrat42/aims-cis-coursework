// Kyra Thomas
// 9/12/2023
// Cryptography

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        // declarations
        int selection, givenNumber, digit1, digit2, digit3, digit4, temp;

        // menu
        // display menu
        System.out.println("            Encryption/Decryption Program");
        System.out.println("-----------------------------------------------------");
        System.out.println();
        System.out.println("                  Choose an option:");
        System.out.println("           1. Encrypt");
        System.out.println("           2. Decrypt");
        System.out.println();
        System.out.print("Make a selection (1/2): ");

        // get choice
        selection = input.nextInt();

        // main if else statement

        if (selection != 1 && selection != 2)
        {
            System.out.print("Try again! Make a selection (1/2): ");
            selection = input.nextInt();
        }
        else
        {
            switch(selection)
            {
                case 1:
                {
                    System.out.print("Enter a 4-digit number: ");
                    givenNumber = input.nextInt();

                    // encrypt
                    // separate into digits
                    digit4 = givenNumber % 10;
                    givenNumber /= 10;
                    digit3 = givenNumber % 10;
                    givenNumber /= 10;
                    digit2 = givenNumber % 10;
                    digit1 = givenNumber / 10;

                    // step 1 encryption
                    digit1 = (digit1 + 7) % 10;
                    digit2 = (digit2 + 7) % 10;
                    digit3 = (digit3 + 7) % 10;
                    digit4 = (digit4 + 7) % 10;

                    // step 2 encryption
                    temp = digit1;
                    digit1 = digit3;
                    digit3 = temp;

                    temp = digit2;
                    digit2 = digit4;
                    digit4 = temp;

                    // output
                    System.out.println("Encrypted number is " + digit1 + "" + digit2 + "" + digit3 + "" + digit4);

                    // end
                    break;

                }
                case 2:
                {
                    System.out.print("Enter a 4-digit number: ");
                    givenNumber = input.nextInt();

                    // decrypt
                    // separate into digits
                    digit4 = givenNumber % 10;
                    givenNumber /= 10;
                    digit3 = givenNumber % 10;
                    givenNumber /= 10;
                    digit2 = givenNumber % 10;
                    digit1 = givenNumber / 10;

                    // step 1 decryption
                    temp = digit1;
                    digit1 = digit3;
                    digit3 = temp;

                    temp = digit2;
                    digit2 = digit4;
                    digit4 = temp;

                    // step 2 decryption
                    digit1 = (((digit1 /10) + 1) * 10) - 7;
                    digit2 = (((digit2 /10) + 1) * 10) - 7;
                    digit3 = (((digit3 /10) + 1) * 10) - 7;
                    digit4 = (((digit4 /10) + 1) * 10) - 7;

                    // output
                    System.out.println("Decrypted number is " + digit1 + "" + digit2 + "" + digit3 + "" + digit4);

                    // end
                    break;
                }
            }
        }

    }
}