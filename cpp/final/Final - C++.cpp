// Kyra Thomas
// 11/24/2023
// Final

#include <iostream>
#include <iomanip>
#include <cstdlib>
#include <time.h>
using namespace std;

// variable declarations
const int SIZE = 3;

int square[SIZE][SIZE];
int testSquare[SIZE][SIZE];     // a Lo Shu magic square for testing purposes

// function prototypes
void initialize(int[][SIZE]);
void printSquare(int[][SIZE]);
void fill(int[][SIZE]);
bool isUnique(int[][SIZE], int);
bool isLoShu(int[][SIZE]);
int sumRow(int[][SIZE], int);
int sumCol(int[][SIZE], int);
int sumDiagDown(int[][SIZE]);
int sumDiagUp(int[][SIZE]);

int main()
{
    // hardcoding the test square
    testSquare[0][0] = 4;
    testSquare[0][1] = 9;
    testSquare[0][2] = 2;
    testSquare[1][0] = 3;
    testSquare[1][1] = 5;
    testSquare[1][2] = 7;
    testSquare[2][0] = 8;
    testSquare[2][1] = 1;
    testSquare[2][2] = 6;

    // seed the random number generator
    srand((unsigned int)time(0));

    // initialize all array values to 0
    initialize(square);

    // fill each value in the array with random unique int 1 - 9
    fill(square);

    // print the array formatted in cols and rows
    printSquare(square);

    // determine if Lo Shu Magic Square (sum of each col, row, diagonal all the same num)
    // print results
    if (isLoShu(testSquare))
        cout << "Is a Lo Shu square!" << endl;
    else
        cout << "Is not a Lo Shu square." << endl;
}

// function implementations

// initializes all values in the square to 0
void initialize(int square[][SIZE])
{
    for (int i = 0; i < SIZE; i++)
    {
        for (int j = 0; j < SIZE; j++)
        {
            square[i][j] = 0;
        }
    }
}

// formats and prints the square
void printSquare(int square[][SIZE])
{
    for (int i = 0; i < SIZE; i++)
    {
        for (int j = 0; j < SIZE; j++)
        {
            cout << setw(4) << left << square[i][j];
        }
        cout << endl;
    }
}

// fills the square with random but unique values between 1 - 9
void fill(int square[][SIZE])
{
    for (int i = 0; i < SIZE; i++)
    {
        for (int j = 0; j < SIZE; j++)
        {
            // generate a random num
            int value = rand() % 9 + 1;

            // while that num exists in square, get new
            while (!isUnique(square, value))
            {
                value = rand() % 9 + 1;
            }

            // set square value at position to this num
            square[i][j] = value;
        }
    }
}

// returns true if the value is not found in the square
bool isUnique(int square[][SIZE], int value)
{
    for (int i = 0; i < SIZE; i++)
    {
        for (int j = 0; j < SIZE; j++)
        {
            if (square[i][j] == value)
                return false;
        }
    }

    // if that value was not found in the square
    return true;
}

// determines if a square is a Lo Shu square
bool isLoShu(int square[][SIZE])
{
    // sum each row
    int row1, row2, row3;
    row1 = sumRow(square, 1);
    row2 = sumRow(square, 2);
    row3 = sumRow(square, 3);

    // sum each column
    int col1, col2, col3;
    col1 = sumCol(square, 1);
    col2 = sumCol(square, 2);
    col3 = sumCol(square, 3);

    // sum each diagonal
    int diagUp = sumDiagUp(square);
    int diagDown = sumDiagDown(square);

    // if all values equal, return true
    if (row1 == row2 && row1 == row3)
    {
        if (col1 == col2 && col1 == col3)
        {
            if (diagUp == diagDown)
                return true;
        }
    }

    // default return false
    return false;
}

// finds the sum of a row in a square
int sumRow(int square[][SIZE], int row)
{
    int sum = 0;

    for (int i = 0; i < SIZE; i++)
    {
        sum += square[row][i];
    }

    return sum;
}

// finds the sum of a column in a square
int sumCol(int square[][SIZE], int col)
{
    int sum = 0;

    for (int i = 0; i < SIZE; i++)
    {
        sum += square[i][col];
    }

    return sum;
}

// finds the sum of the diagonal of a square from top left to bottom right
int sumDiagDown(int square[][SIZE])
{
    int sum = 0;

    for (int i = 0; i < SIZE; i++)
    {
        sum += square[i][i];
    }
    
    return sum;
}

// finds the sum of the diagonal of a square from bottom left to top right
int sumDiagUp(int square[][SIZE])
{
    int sum = 0;

    sum += square[2][0];
    sum += square[1][1];
    sum += square[0][2];

    return sum;
}