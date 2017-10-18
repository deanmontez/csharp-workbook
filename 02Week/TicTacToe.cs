using System;

public class Program
{
    public static string playerTurn = "X";
    public static string[][] board = new string[][]
    {
        new string[] {" ", " ", " "},
        new string[] {" ", " ", " "},
        new string[] {" ", " ", " "}
     };

    public static void Main()
    {
        while ( !CheckForWin() )
        {
            DrawBoard();
            GetInput();
            if ( CheckForWin() )
            {
                DrawBoard();
                Console.WriteLine("Player " + playerTurn + " Won!");
                Console.ReadLine();
            }
            else
            {
                playerTurn = (playerTurn == "X") ? "O" : "X";
            }
        }
    }

    public static void GetInput()
    {
        Console.WriteLine("Player " + playerTurn);
        Console.WriteLine("Enter Row:");
        int row = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter Column:");
        int column = Int32.Parse(Console.ReadLine());

        PlaceMark(row, column);
    }

    public static void PlaceMark(int row, int column)
    {
        if (board[row][column] == " ")
        {
            board[row][column] = playerTurn;
        }
        else
        {
            Console.WriteLine("Space is already occupied, pick another one please!");
            GetInput();
        }
        
        return;
    }

    public static bool CheckForWin()
    {
        return (HorizontalWin() || VerticalWin() || DiagonalWin());
    }

    public static bool HorizontalWin()
    {
        return ((board[0][0] == playerTurn && board[0][1] == playerTurn && board[0][2] == playerTurn) ||
                (board[1][0] == playerTurn && board[1][1] == playerTurn && board[1][2] == playerTurn) ||
                (board[2][0] == playerTurn && board[2][1] == playerTurn && board[2][2] == playerTurn));
    }

    public static bool VerticalWin()
    {
        return ((board[0][0] == playerTurn && board[1][0] == playerTurn && board[2][0] == playerTurn) ||
                (board[0][1] == playerTurn && board[1][1] == playerTurn && board[2][1] == playerTurn) ||
                (board[0][2] == playerTurn && board[1][2] == playerTurn && board[2][2] == playerTurn));
    }

    public static bool DiagonalWin()
    {
        return ((board[0][0] == playerTurn && board[1][1] == playerTurn && board[2][2] == playerTurn) ||
                (board[2][0] == playerTurn && board[1][1] == playerTurn && board[0][2] == playerTurn));
    }

    public static void DrawBoard()
    {
        Console.WriteLine("  0 1 2");
        Console.WriteLine("0 " + String.Join("|", board[0]));
        Console.WriteLine("  -----");
        Console.WriteLine("1 " + String.Join("|", board[1]));
        Console.WriteLine("  -----");
        Console.WriteLine("2 " + String.Join("|", board[2]));
        return;
    }
}
