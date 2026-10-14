// Kyra Thomas
// 10/27/2023
// Rock Paper Scissors - new version

#include <iostream>
#include <cstdlib>
using namespace std;

// function declarations
void computerTurn(int &);
void printMenu();
int userTurn();
string determineWinner(int, int, string&);
void results(int, int, string, string);

int main()
{
    // seed the random number generator
    srand((unsigned)time(NULL));    // I had to Google this, so I'm not sure if it will work

    // pseudocode:
    // while player choice is not 4
        // get the computer's choice 
        // print main menu
        // get and validate the user's choice
        // break if user inputs 4 to exit
        // calculate the winners or tie
        // display the choices and result

    int player = 0, computer = 0;
    string winner = "";
    string winCondition;

    // main loop
    while (player != 4)
    {
        // get the computer's choice
        computerTurn(computer);

        // print the main menu
        printMenu();

        // get and validate user choice
        player = userTurn();

        // break main loop if user enters 4 to exit
        if (player == 4)
            break;

        // determines the winner and sets a win condition string
        winCondition = determineWinner(computer, player, winner);

        // print results
        results(computer, player, winner, winCondition);
    }
}

// function implementations
void computerTurn(int& computer)
{
    // generates a random number between 1 and 3
    // assigns random number to computer's choice (pass-by reference)
    computer = (rand() % 3) + 1;
}

void printMenu()
{
    // prints the main menu
    cout << "Main Menu" << endl;
    cout << "-----------------" << endl;
    cout << "1) Rock" << endl;
    cout << "2) Paper" << endl;
    cout << "3) Scissors" << endl;
    cout << "4) Quit" << endl;
}

int userTurn()
{
    int choice;

    cout << "\nEnter your choice: ";
    cin >> choice;

    // validation loop
    while (choice < 1 || choice > 4)
    {
        cout << "\nChoice must be between 1 and 4. Enter your choice: ";
        cin >> choice;
    }

    return choice;
}

string determineWinner(int c, int p, string& winner)
{
    // uses a pass-by reference to modify the winner string
    // and returns a win condition string

    // winner options: computer, player, tie
    // 1 = rock
    // 2 = paper
    // 3 = scissors

    // using an else-if because all need to be mutually exclusive
    // win condition 1: rock beats scissors
    if (c == 1 && p == 3)
    {
        winner = "computer";
        return "Rock beats scissors.";
    }
    else if (p == 1 && c == 3)
    {
        winner = "player";
        return "Rock beats scissors.";
    }

    // win condition 2: scissors beats paper
    else if (c == 3 && p == 2)
    {
        winner = "computer";
        return "Scissors beats paper.";
    }
    else if (p == 3 && c == 2)
    {
        winner = "player";
        return "Scissors beats paper.";
    }

    // win condition 3: paper beats rock
    else if (c == 2 && p == 1)
    {
        winner = "computer";
        return "Paper beats rock.";
    }
    else if (p == 2 && c == 1)
    {
        winner = "player";
        return "Paper beats rock.";
    }

    // tie catch-all condition
    else
    {
        winner = "tie";
        return "No winner.";
    }
}

void results(int c, int p, string winner, string winCondition)
{
    // print user choice
    cout << "You selected: ";
    if (p == 1)
        cout << "Rock" << endl;
    else if (p == 2)
        cout << "Paper" << endl;
    else
        cout << "Scissors" << endl;

    // print computer choice
    cout << "Computer selected: ";
    if (c == 1)
        cout << "Rock" << endl;
    else if (c == 2)
        cout << "Paper" << endl;
    else
        cout << "Scissors" << endl;

    // print winner and win condition
    if (winner == "player")
        cout << "You win! " << winCondition << endl;
    else if (winner == "computer")
        cout << "Computer wins. " << winCondition << endl;
    else
        cout << "Tie. " << winCondition << endl;
}