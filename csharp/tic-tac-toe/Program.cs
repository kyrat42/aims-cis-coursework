// Kyra Thomas
// 12/2/2023
// Tic Tac Toe

using System;
using System.Data;
using System.Threading.Channels;

namespace TicTacToe2
{
    class Program
    {
        private static char[,] board = new char[3, 3];
        private static char turn = 'X';

        static void Main(string[] args)
        {
            Console.WriteLine("Tic Tac Toe");

            string keepPlaying = "Y";

            // while player wants to keep playing
            while (keepPlaying.ToUpper() == "Y")
            {
                InitializeArray();

                // test code for hardcoding the board, currently a diagonal down of X
                // board[0, 0] = 'X';
                // board[1, 1] = 'X';
                // board[2, 2] = 'X';

                PrintBoard();

                char winState = ' ';

                // while the game is in play
                while (winState == ' ')
                {
                    // if turn = x, player turn
                    if (turn == 'X')
                        PlayerTurn();

                    // if turn = o, computer turn
                    else
                        ComputerTurn();

                    // print the board
                    PrintBoard();

                    // SwitchTurn
                    SwitchTurn();

                    winState = WinState();
                }

                // once the game has finished, give appropriate output
                if (WinState() == 'T')
                    Console.WriteLine("It's a cat's game!");
                else
                    Console.WriteLine($"{WinState()} has won the game!");

                // keep playing?
                Console.Write("Would you like to keep playing? (Y/N): ");
                keepPlaying = Console.ReadLine();
            }
        }

        static void InitializeArray()
        {
            for (int row  = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = ' ';
                }
            }
        }

        static void PrintBoard()
        {
            Console.WriteLine("      0     1     2");
            Console.WriteLine("   -------------------");
            for (int row = 0; row < 3; row++)
            {
                Console.Write(row + "  ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write($"|  {board[row, col]}  ");
                }
                Console.WriteLine("|");
                Console.WriteLine("   -------------------");
            }
        }

        // switches the turn from X to O and vice versa
        // call this at the end of each turn
        static void SwitchTurn()
        {
            if (turn == 'X')
                turn = 'O';
            else
                turn = 'X';

            // test code - prints the turn we're currently on.
            // Console.WriteLine(turn);
        }

        // determines if there has been a winner yet. use in a while loop
        // win conditions:
        // - all in a row same char
        // - all in a col same char
        // - all in a diag same char
        // - all spaces are filled (could be a tie)
        static char WinState()
        {
            // X
            // O
            // space = game still in progress
            // T = tie

            if (Winner() != ' ')
                return Winner();

            // game still in progress (there are still some spaces on the board, and no winner yet)
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (board[row, col] == ' ')
                        return ' ';
                }
            }

            // if there is no winner, and there are no more spaces on the board, it is a tie
            return 'T';
        }

        // checks all possible win conditions and returns the winning char
        static char Winner()
        {
            // check 3 rows
            for (int row = 0; row < 3; row++)
            {
                // if all values in this row are the same
                if (board[row, 0] == board[row, 1] && board[row, 0] == board[row, 2])
                    // return the char at the first point
                    return board[row, 0];
            }

            // check 3 cols
            for (int col = 0; col < 3; col++)
            {
                // if all values in this col are the same
                if (board[0, col] == board[1, col] && board[0, col] == board[2, col])
                    // return the char at the first point
                    return board[0, col];
            }

            // check 2 diags
            // top left to bottom right
            if (board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2])
                return board[0, 0];

            // bottom left to top right
            if (board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0])
                return board[0, 2];

            // if no win conditions met, return space
            return ' ';
        }

        static void PlayerTurn()
        {
            int row, col;

            // main validation loop
            do
            {
                // read and validate row value (0-2)
                Console.Write("Enter a row value (0 - 2): ");
                row = int.Parse(Console.ReadLine());

                while (row < 0 || row > 2)
                {
                    Console.Write("Try again. Enter a row value (0 - 2): ");
                    row = int.Parse(Console.ReadLine());
                }

                // read and validate col value (0-2)
                Console.Write("Enter a column value (0 - 2): ");
                col = int.Parse(Console.ReadLine());

                while (col < 0 || col > 2)
                {
                    Console.Write("Try again. Enter a column value (0 - 2): ");
                    col = int.Parse(Console.ReadLine());
                }

                // validates that this coordinate is available, else gives error message and loops back
                if (!IsAvailable(row, col))
                    Console.WriteLine("That coordinate is not available. Please try again.");

            } while (!IsAvailable(row, col));

            // assign x to the coordinate
            board[row, col] = 'X';
        }

        // validates the availability of a coordinate
        static bool IsAvailable(int row, int col)
        {
            if (board[row, col] != ' ')
                return false;

            return true;
        }

        // computer's turn
        static void ComputerTurn()
        {
            int row = -1, col = -1;       // just initializing them

            // main validation loop
            do
            {
                /* I don't think this part is working
                // check for near win conditions for and add an o to block or complete the win (extra credit)
                // check 3 rows
                for (int i = 0; i < 3; i++)
                {
                    // if 2 values in this row are the same
                    // first 2 are the same
                    if (board[i, 0] == board[i, 1])
                    {
                        // set the coordinate to the last in the row
                        row = i;
                        col = 2;
                        break;
                    }
                    // outer 2 are the same
                    else if (board[i, 0] == board[i, 2])
                    {
                        // set the coordinate to the middle in the row
                        row = i;
                        col = 1;
                        break;
                    }
                    // last 2 are the same
                    else if (board[i, 1] == board[i, 2])
                    {
                        // set the coordinate to the middle in the row
                        row = i;
                        col = 0;
                        break;
                    }
                }

                // check 3 cols
                for (int i = 0; i < 3; i++)
                {
                    // if 2 values in this col are the same
                    // first 2 are the same
                    if (board[0, i] == board[1, i])
                    {
                        // set the coordinate to the last in the col
                        row = 2;
                        col = i;
                        break;
                    }
                    // outer 2 are the same
                    else if (board[0, i] == board[2, i])
                    {
                        // set the coordinate to the middle in the col
                        row = 1;
                        col = i;
                        break;
                    }
                    // last 2 are the same
                    else if (board[1, i] == board[2, i])
                    {
                        // set the coordinate to the middle in the col
                        row = 0;
                        col = i;
                        break;
                    }
                }

                // check 2 diags
                // top left to bottom right
                if (board[0, 0] == board[1, 1])
                {
                    row = 2;
                    col = 2;
                }
                else if (board[0, 0] == board[2, 2])
                {
                    row = 1;
                    col = 1;
                }
                else if (board[1, 1] == board[2, 2])
                {
                    row = 0;
                    col = 0;
                }

                // bottom left to top right
                if (board[0, 2] == board[1, 1])
                {
                    row = 2;
                    col = 0;
                }
                else if (board[0, 2] == board[2, 0])
                {
                    row = 1;
                    col = 1;
                }
                else if (board[1, 1] == board[2, 0])
                {
                    row = 0;
                    col = 2;
                }


                // place o's in strategic locations (if I have time)

                */

                // generate a random num between 0 - 2 for row and col only if row and col are not filled by the above checks
                Random random = new Random();
                row = random.Next(0, 3);
                col = random.Next(0, 3);

            // this is going to repeat this whole process until a coordinate that is available is generated.
            // I don't think this is the most efficient way, but for now it works.
            } while (!IsAvailable(row, col));

            // assign o to the coordinate
            board[row, col] = 'O';
        }
    }
}