using System;

namespace tictactoe
{
  class Program
  {
    public static char CurrentPlayer;
    public static void markSpot(int x, int y)
    {
      if (Matrix.Table[x][y] != ' ')
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("SPOT HAS BEEN CLAIMED");
        Console.ResetColor();
      }
      else
      {
        Matrix.Table[x][y] = CurrentPlayer;
        if (Determine.Winner(CurrentPlayer))
        {
          Console.BackgroundColor = ConsoleColor.Blue;
          Console.ForegroundColor = ConsoleColor.White;
          Console.WriteLine($"*** {CurrentPlayer}  WINS!!! ***");
          Console.ResetColor();
          Environment.Exit(0);
        }
        else {
          CurrentPlayer = CurrentPlayer == 'X' ? 'O' : 'X';
        }
      }
    }
    public static void Main()
    {
      try
      {
        int input;
        CurrentPlayer = 'X';
        do
        {
          Console.WriteLine(Board.CurrentStatus(Matrix.Table));
          Console.WriteLine($"Current Player: {CurrentPlayer}");
          Console.Write("Mark a spot (1-9): ");
          input = int.Parse(Console.ReadLine());
          switch (input)
          {
            case 1:
              markSpot(0, 0);
              break;
            case 2:
              markSpot(0, 1);
              break;
            case 3:
              markSpot(0, 2);
              break;
            case 4:
              markSpot(1, 0);
              break;
            case 5:
              markSpot(1, 1);
              break;
            case 6:
              markSpot(1, 2);
              break;
            case 7:
              markSpot(2, 0);
              break;
            case 8:
              markSpot(2, 1);
              break;
            case 9:
              markSpot(2, 2);
              break;
            default:
              Console.WriteLine($"{input} is not a valid input");
              break;
          }
        } while (input < 10);
      }
      catch (FormatException)
      {
        throw new System.FormatException();
      }
    }
  }
}
