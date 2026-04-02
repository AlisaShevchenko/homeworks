﻿Console.Write("Enter the name of the first player: ");
string player1 = Console.ReadLine();
Console.Write("Enter the name of the second player: ");
string player2 = Console.ReadLine();


static void DisplayPlayfield<T>(T[,] matrix)
{ 
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    
    for (int i = 0; i < rows; i++)
    {
        Console.WriteLine(new string('_', 3*4 +1));
        for (int j = 0; j < cols; j++)
        {
            string value = matrix[i, j]?.ToString()?? "null";
            Console.Write($"| {matrix[i,j], 1} ");
        }
        Console.WriteLine("|");
    }
    Console.WriteLine(new string('_', 3*4 +1));
}

static bool CheckWinner(string[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (matrix[i, 0] == "X" || matrix[i, 0] == "0")
        {
            if ((matrix[i, 0] == matrix[i, 1]) && (matrix[i, 0] == matrix[i, 2]))
            {
                return true;
            }
        }
    }

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[0, j] == "X" || matrix[0, j] == "0")
        {
            if ((matrix[0, j] == matrix[1, j]) && (matrix[1, j] == matrix[2, j]))
            {
                return true;
            }
        }
    }

if (matrix[1, 1] == "X" || matrix[1, 1] == "0")
    {

        if ((matrix[0, 0] == matrix[1, 1]) && (matrix[1, 1] == matrix[2, 2]))
        {
            return true;
        }

        if ((matrix[0, 2] == matrix[1, 1]) && (matrix[1, 1] == matrix[2, 0]))
        {
            return true;
        }
    }
    return false;
}


string[,] game = {
    {"1", "2", "3"},
    {"4", "5", "6"},
    {"7", "8", "9"} 
};

int moves = 0;
string currentSymbol = "X";
string currentPlayer = player1;

DisplayPlayfield(game);

while (!CheckWinner(game) && moves < 9)
{
    Console.WriteLine($"Player {currentPlayer} is moving");
    bool isMoveValid = false;
    int choiseFirstPlayer = 0;
    while (!isMoveValid)
    {
        if (!int.TryParse(Console.ReadLine(), out choiseFirstPlayer) || choiseFirstPlayer < 0 ||
            choiseFirstPlayer > game.Length)
        {
            Console.WriteLine("Please enter a correct number between 1 and 9.");
            continue;
        }

        for (int i = 0; i < game.GetLength(0); i++)
        {
            for (int j = 0; j < game.GetLength(1); j++)
            {

                if (game[i, j] == choiseFirstPlayer.ToString())
                {
                    game[i, j] = currentSymbol;
                    isMoveValid = true;
                    moves++;
                    break;
                }
            }

            if (isMoveValid)
                break;
        }

        if (!isMoveValid)
        {
            Console.WriteLine("This value is already taken or invalid; please choose another.");
        }

    }

    DisplayPlayfield(game);
    if (CheckWinner(game) == true)
    {
        Console.WriteLine($"Congratulations! {currentPlayer} won the game!");
        break;
    }

    if ((CheckWinner(game) == false) && moves == 9)
    {
        Console.WriteLine("Draw");
        break;
    }

    if (currentSymbol == "X")
    {
        currentSymbol = "0";
        currentPlayer = player2;
    }
    else
    {
        currentSymbol = "X";
        currentPlayer = player1;
    }
}