// Kyra Thomas
// 11/17/2023
// Game of Hunt

#include <iostream>
#include <cctype>
#include <iomanip>
#include <string>
using namespace std;

// constants
const int COLUMNS = 10, ROWS = 10;

// game state structure
struct game_info
{
    // a 2D Array to keep track of previous guesses
    bool prevGuesses[10][10];

    // The treasure
    int treasure = 1000;

    // treasure location
    int tRow;
    int tColumn;

    // guess location
    int gRow = -1;
    int gColumn = -1;
};

// function prototypes
void printIntroScreen();
void initializePrevGuesses(game_info&);
void printPrevGuesses(game_info&);          // for testing
void hideTreasure(game_info&);
void printTreasure(game_info&);             // for testing
bool isWon(game_info&);
bool isLost(game_info&);
void displayBoard(game_info&);
void getGuess(game_info&);
string getSymbol(game_info&);

int main()
{
    // seed the random generator
    srand((unsigned int)time(0));

    // game holds the state of the game
    game_info game;

    // print initial output
    printIntroScreen();

    char keepPlaying = 'Y';

    // while keepPlaying is Y or y (case insensitive), run program
    while (toupper(keepPlaying) == 'Y')
    {
        // re-set the game
        initializePrevGuesses(game);
        game.treasure = 1000;
        game.gRow = -1;
        game.gColumn = -1;
        hideTreasure(game);

        // while the game is not won or lost, keep playing this game
        while (!isWon(game) && !isLost(game))
        {
            // print the board and treasure amount
            displayBoard(game);

            // get the next guess - update prevGuesses and decrement the treasure
            getGuess(game);
        }

        if (isWon(game))
            cout << "You won $" << game.treasure << "!" << endl;
        else
            cout << "You lose." << endl;

        // play again?
        cout << "Would you like to play again? (Y/N): ";
        cin >> keepPlaying;
    }
}

// function implementations
void printIntroScreen()
{
    cout << "     WELCOME TO THE TREASURE HUNT GAME!" << endl;
    cout <<"The object of the game is to find the treasure:" << endl;
    cout << "located somewhere on a 10 x 10 board. Enter row and" << endl;
    cout << "column guesses (0 - 9) and receive a clue to the treasure" << endl;
    cout << "location. Each guess will deduct $50 from the treasure" << endl;
    cout << "value. Here are some clues you may receive:" << endl;
    cout << "\'U3\' means go up 3 rows." << endl;
    cout << "\'D4\' means go down 4 rows." << endl;
    cout << "\'->\' means go to the right." << endl;
    cout << "\'<-\' means go to the left." << endl;
    cout << "\'?\' means no information this turn." << endl;
    cout << "\'+$\' means $50 was added to the treasure." << endl;
    cout << "\'-$\' means an extra $50 was deducted from the treasure." << endl;
    cout << "Good luck on the treasure hunt!" << endl;
    cout << "Press enter to continue: ";

    // pauses until user presses enter
    cin.get();
}

// this initializes the previous guesses array
void initializePrevGuesses(game_info& g)
{
    for (int row = 0; row < ROWS; row++)
    {
        for (int col = 0; col < COLUMNS; col++)
        {
            g.prevGuesses[row][col] = false;
        }
    }
}

// this can print the previous guesses array for testing purposes
// formatted as a 10 x 10 matrix
void printPrevGuesses(game_info& g)
{
    for (int row = 0; row < ROWS; row++)
    {
        for (int col = 0; col < COLUMNS; col++)
        {
            cout << g.prevGuesses[row][col] << "  ";
        }
        cout << endl;
    }
}

// hides the treasure at a random coordinate within the grid
void hideTreasure(game_info& g)
{
    g.tRow = rand() % ROWS;
    g.tColumn = rand() % COLUMNS;
}

// prints the treasure coordinates for testing purposes
void printTreasure(game_info& g)
{
    cout << "The treasure is at: " << g.tRow << ", " << g.tColumn << endl;
}

// if the user guessed the treasure spot, the game is won
bool isWon(game_info& g)
{

    if ((g.gRow == g.tRow && g.gColumn == g.tColumn))
    {
        return true;
    }
    return false;
}

// if the treasure is less than or equal to zero, the
// game is lost
bool isLost(game_info& g)
{
    if (g.treasure <= 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

// displays the board and the treasure amount
void displayBoard(game_info& g)
{
    // display column #s
    cout << "    0   1   2   3   4   5   6   7   8   9" << endl;

    // if the game is not lost, it should give ## at each point except where the current guess is
    if (!isLost(g))
    {
        for (int row = 0; row < ROWS; row++)
        {
            // display the rows
            cout << row << "  ";

            for (int col = 0; col < COLUMNS; col++)
            {
                // if this coordinate is the current guess, get a symbol
                if (g.gRow == row && g.gColumn == col)
                {
                    cout << getSymbol(g) << "  ";
                }

                // else print ##
                else
                {
                    cout << "##" << "  ";
                }
            }
            cout << endl;
        }
    }

    // if the game is lost, it should give xx for all spots
    else 
    {
        for (int row = 0; row < ROWS; row++)
        {
            // display the row #s
            cout << row << "  ";

            // this is currently only displaying the initial game state
            for (int col = 0; col < COLUMNS; col++)
            {
                cout << "XX" << "  ";
            }
            cout << endl;
        }
    }

    // displays the current treasure amount
    cout << "\nThe treasure is: $" << g.treasure;
}

// gets the guess from the user
void getGuess(game_info& g)
{
    cout << "\n\nEnter row: ";
    cin >> g.gRow;
    cout << "Enter col: ";
    cin >> g.gColumn;

    // validate that this guess has not been made 
    while (g.prevGuesses[g.gRow][g.gColumn])
    {
        cout << "That guess has already been made. Try again." << endl;
        cout << "Enter row: ";
        cin >> g.gRow;
        cout << "Enter col: ";
        cin >> g.gColumn;
    }

    // update previous guesses
    g.prevGuesses[g.gRow][g.gColumn] = true;

    // if this does not win the game
    if (!isWon(g))
        g.treasure -= 50;
}

string getSymbol(game_info& g)
{
    int random = rand() % 5;

    switch (random)
    {
        // if this is the right guess
        if (isWon(g))
            return "$$";
       
        // up, down, or neither
        case (0):
        {
            // up
            if (g.gRow > g.tRow)
            {
                // returns "U#" where # is the number of rows up that the treasure is from the guess
                return "U" + to_string(g.gRow - g.tRow);
            }

            // down
            else if (g.gRow < g.tRow)
            {
                // returns "D#" where # is the number of rows down that the treasure is from the guess
                return "D" + to_string(g.tRow - g.gRow);
            }

            // else if the guess is in the same row as the treasure
            else
            {
                return "||";
            }
        }

        // left, right, or neither
        case (1):
        {
            // left
            if (g.gColumn > g.tColumn)
            {
                return "<-";
            }

            // right
            else if (g.gColumn < g.tColumn)
            {
                return "->";
            }

            // same column
            else
            {
                return "--";
            }
        }

        // add money
        case (2):
        {
            g.treasure += 100;      // this adds 100 (50 bonus and 50 to make up for this turn's loss)
            return "+$";
        }
        
        // subtract money
        case(3):
        {
            g.treasure -= 50;
            return "-$";
        }

        // if random is 4 or anything else
        default:
            return "??";        // no info given this turn
    }
}