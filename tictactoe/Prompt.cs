using System;

namespace tictactoe
{
  class Prompt
  {
    public static void SpotTaken()
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("\nSPOT HAS BEEN CLAIMED");
      Console.ResetColor();
    }

    public static void ContinuePlaying()
    {
      Console.WriteLine(Board.CurrentStatus(Matrix.Table));
      Console.WriteLine($"Current Player: {Program.CurrentPlayer}");
      Console.Write("Mark a spot (1-9): ");
    }

    public static void Winner()
    {
      Console.WriteLine(Board.CurrentStatus(Matrix.Table));
      Console.BackgroundColor = ConsoleColor.Blue;
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine($"*** {Program.CurrentPlayer}  WINS!!! ***");
      Console.ResetColor();
      Environment.Exit(0);
    }
  }
}
