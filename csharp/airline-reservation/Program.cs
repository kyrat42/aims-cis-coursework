// Kyra Thomas
// 11/1/2023
// Airline Reservation

// assignment info:
// airplane capacity = 10
// choose first class (1) seats 1-5 or economy (2) seats 6-10
// if economy full, ask user if they want to book in first class instead, vice versa
// if plane or chosen section full, display next flight leaves in 3 hours
// validate all input
// 1 bool array all initialized to false

using System;
using System.ComponentModel.Design;
using System.Net.WebSockets;

class Airplane
{
    // global variable
    const int CAPACITY = 10;

    // main
    static void Main()
    {
        // while plane is not full
        //      print the plane
        //      ask user economy or first class, validate
        //      book seat in appropriate class if available
        //      if that section full, ask about the other section, validate
        //      display seat # booked
        //      if no seat is booked, display next flight leaves in 3 hours

        bool[] airplane = new bool[CAPACITY];
        bool isPlaneFull = false;

        while (!isPlaneFull)
        {
            printPlane(airplane);
            int section = getSection();

            // run bookSeat if the section input was valid
            if (section == 1 || section == 2)
            {
                int seat = bookSeat(airplane, section, isPlaneFull);
                if (seat != -1)
                    Console.WriteLine($"Seat {seat} was booked in " + (seat > 5 ? "economy." : "first class."));
                else
                {
                    isPlaneFull = true;
                    Console.WriteLine("\nThe flight is full. The next flight leaves in 3 hours.");
                }
            }
            else
            {
                Console.Write("No seat was booked. Press enter to continue. ");
                Console.ReadLine();
            }
        }

        Console.Write("Press enter to exit. ");
        Console.ReadLine();
    }

    // other methods
    static void printPlane(bool[] airplane)
    {
        Console.WriteLine("                  Airplane");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("|       FIRST CLASS       |         ECONOMY        |");
        Console.WriteLine("----------------------------------------------------");
        Console.Write("| ");
        for (int i = 0; i < airplane.Length; i++)
        {
            // prints an X if the seat is full, otherwise prints blank space
            Console.Write("  " + (airplane[i] ? "X" : " ") + " |");
        }
        Console.WriteLine();
        Console.WriteLine("----------------------------------------------------");
        Console.Write("|");
        for (int i = 1; i < (airplane.Length + 1); i++)
        {
            // prints the seat numbers
            Console.Write("  " + i + " |");
        }
    }

    static int getSection ()
    {
        // get section from user
        Console.Write("\n\nEconomy or First Class? (1 for Economy, 2 for First Class): ");
        int input = int.Parse(Console.ReadLine());
        return input;
    }

    static int bookSeat(bool[] airplane, int section, bool isPlaneFull)
    {
        // attempt to book in given section
        // if there are seats available in section
        // if there are no seats in section, but there are some in other section, offer that
        // return first available seat
        // if plane is full, return  -1

        int openSeat;
        string reBook;

        if (airplane[9] && airplane[4])
        {
            isPlaneFull = true;
            return -1;
        }

        if (section == 1)
        {
            openSeat = checkAvailability(airplane, 5, airplane.Length, isPlaneFull);

            // if the section is full openSeat will return -1
            if (openSeat == -1)
            {
                Console.Write("Economy is full! Would you like to book first class? (Y/N): ");
                reBook = Console.ReadLine();

                if (reBook.ToUpper() == "Y")
                {
                    section = 2;
                    openSeat = checkAvailability(airplane, 0, 5, isPlaneFull);
                    airplane[openSeat] = true;
                    return openSeat + 1;
                }
            }
            else
            {
                airplane[openSeat] = true;
                return openSeat +1;
            }
        }

        else    // section has to be 1 or 2 because it was already validated
        {
            openSeat = checkAvailability(airplane, 0, 5, isPlaneFull);

            // if the section is full openSeat will return -1
            if (openSeat == -1)
            {
                Console.Write("First class is full! Would you like to book economy? (Y/N): ");
                reBook = Console.ReadLine();

                if (reBook.ToUpper() == "Y")
                {
                    section = 1;
                    openSeat = checkAvailability(airplane, 5, airplane.Length, isPlaneFull);
                    airplane[openSeat] = true;
                    return openSeat + 1;
                }
            }
            else
            {
                airplane[openSeat] = true;
                return openSeat + 1;
            }
        }

        // if it hasn't returned a value yet, the airplane is full
        isPlaneFull = true;
        return -1;
    }
    static int checkAvailability(bool[] airplane, int startSeat, int endSeat, bool isPlaneFull)
    {
        for (int i = startSeat; i < endSeat; i++)
        {
            if (!airplane[i])
                return i;
        }

        // if the last seat in each section is taken, set isPlaneFull to true
        if (airplane[9] && airplane[4])
            isPlaneFull = true;

        return -1;
    }
}