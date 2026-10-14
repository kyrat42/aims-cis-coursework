// Kyra Thomas
// 11/5/2023
// Lotto Program

#include <iostream>
#include <iomanip>
#include <cstdlib>
using namespace std;

// strategy: code the calculate winnings part first with hardcoded values for the tickets to test
// note: this is all working now 11/6/2023
// just finished print menu and getting user selection 11/7/2023
// then code the quick pick and print the array values to be sure it is giving unique numbers
// quick pick is working 11/8/2023
// don't forget to run randomFill() again for the winningTicket and powerball
// then code the user input function and print the values to test. use isUnique() again

// function prototypes
string determineWinning(int [], int, int [], int, int);
int getSelection();
int randomFill(int [], int);
bool isUnique(int[], int, int);
int pickNumbers(int [], int);
void printTicket(string, int[], int, int);

// main
int main()
{
    // declarations
    const int TICKET_LENGTH = 5;

    int userSelection = 0;
    int userTicket[TICKET_LENGTH];
    int userPowerball;                               
    int winningTicket[TICKET_LENGTH];   
    int winningPowerball;


    // while user selection != 3
        // print menu and get user's selection
        // switch statement for userSelection
        // 1 - quick pick
        // 2 - pick numbers
        // 3 - break
        // generate winning numbers
        // determine winnings and print
    while (userSelection != 3)
    {
        // print menu and get user selection
        userSelection = getSelection();

        // switch statement for user selection
        switch (userSelection)
        {
            // quick pick
            case(1):
                userPowerball = randomFill(userTicket, TICKET_LENGTH);
                break;

            // user input
            case(2):
                userPowerball = pickNumbers(userTicket, TICKET_LENGTH);
                break;

            // exit
            case(3):
                break;
        }

        // break while loop if userSelection is 3
        if (userSelection == 3)
            break;

        // fill the winningTicket with random values
        winningPowerball = randomFill(winningTicket, TICKET_LENGTH);

        // print tickets with formatting
        printTicket("Player's ticket: ", userTicket, userPowerball, TICKET_LENGTH);
        cout << endl;
        printTicket("Drawing: ", winningTicket, winningPowerball, TICKET_LENGTH);
        cout << endl;
        
        // cout winnings results
        cout << determineWinning(userTicket, userPowerball, winningTicket, winningPowerball, TICKET_LENGTH) << endl;
    }
}

// function implementations

// print menu and get user' selection
int getSelection()
{
    int selection;

    // print menu
    cout << "       Welcome to the Lottery" << endl;
    cout << "------------------------------------" << endl;
    cout << setw(4) << left << "1." << "Quick Pick" << endl;
    cout << setw(4) << left << "2." << "Pick Numbers" << endl;
    cout << setw(4) << left << "3." << "Exit" << endl;

    // get selection
    cout << "Selection: ";
    cin >> selection;

    // validate selection
    while (selection < 1 || selection > 3)
    {
        cout << "Select a number between 1 and 3. Try again: ";
        cin >> selection;
    }

    return selection;
}

// fills the ticket with random numbers, returns the powerball int
int randomFill(int ticket[], int length)
{
    int valuesInArray = 0;

    // for each value in the ticket
    for (int i = 0; i < length; i++)
    {
        // generate a random number between 1 - 69
        int random = (rand() % 69) + 1;

        // while random is not unique within the ticket
        while (!isUnique(ticket, random, i))
        {
            // re-generate random
            random = (rand() % 69) + 1;
        }

        // once the while loop completes, random will contain a unique number
        // assign that number to this position in the ticket
        ticket[i] = random;
    }

    // return a random powerball between 1 - 26
    return (rand() % 26) + 1;
}

// checks if a number is unique within a given array
bool isUnique(int array[], int value, int count)
{
    // check each of the values that are already in the array
    for (int i = 0; i < count; i++)
    {
        // flag false if this value is in the array already
        if (array[i] == value)
            return false;
    }

    // if no false flags, return true
    return true;
}

// pick numbers 
int pickNumbers(int ticket[], int length)
{
    int powerball;

    // for every value in length
    for (int i = 0; i < length; i++)
    {
        cout << "Input a unique number between 1 and 69 for number " << (i + 1) << ": ";
        cin >> ticket[i];

        // while that number is not unique, try again
        while (!isUnique(ticket, ticket[i], i) || ticket[i] < 1 || ticket[i] > 69)
        {
            cout << "Invalid. Please try again: ";
            cin >> ticket[i];
        }
    }

    // get the powerball
    cout << "Pick a number between 1 and 26 for your powerball: ";
    cin >> powerball;

    // validate powerball
    while (powerball < 1 || powerball > 26)
    {
        cout << "Invalid. Please try again: ";
        cin >> powerball;
    }

    return powerball;
}

// determine winnings returns string
// receives user ticket and powerball, winning ticket and powerball, and the const TICKET_LENGTH
// returns a string expressing the appropriate winnings
string determineWinning(int userTicket[], int userPowerball, int winningTicket[], int winningPowerball, int length)
{
    string prize = "";
    int matchCount = 0;
    bool doesPowerballMatch = false;

    // calculate matches
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length; j++)
        {
            if (userTicket[i] == winningTicket[j])
                matchCount++;
        }
    }

    // flag true if powerball matches
    if (userPowerball == winningPowerball)
        doesPowerballMatch = true;

    // set prize
    if ((doesPowerballMatch && matchCount == 0) || (doesPowerballMatch && matchCount == 1))
        prize = "$4";
    else if ((doesPowerballMatch && matchCount == 2) || (!doesPowerballMatch && matchCount == 3))
        prize = "$7";
    else if ((doesPowerballMatch && matchCount == 3) || (!doesPowerballMatch && matchCount == 4))
        prize = "$100";
    else if (doesPowerballMatch && matchCount == 4)
        prize = "$50,000";
    else if (!doesPowerballMatch && matchCount == 5)
        prize = "$1 million";
    else if (doesPowerballMatch && matchCount == 5)
        prize = "the Grand Prize!";

    // if prize is not empty
    if (prize != "")
        return "You won " + prize;
    else
        return "Better luck next time.";
}

// prints a formatted ticket
// string parameter is the first part of the output (whoever's ticket)
void printTicket(string player, int ticket[], int powerball, int length)
{
    cout << setw(20) << left << player;

    for (int i = 0; i < length; i++)
        cout << setw(4) << left << ticket[i];

    cout << setw(6) << right << powerball;
}