using System;

namespace tictactoe
{
  class Program
  {
    public static char CurrentPlayer;
    public static void MakeMove(int x, int y)
    {
      if (Matrix.Table[x][y] != ' ')
        Prompt.SpotTaken();
      else
        Matrix.MarkSpot(x,y);
    }
    public static void Main()
    {
      try
      {
        int input;
        CurrentPlayer = 'X';
        do
        {
          Prompt.ContinuePlaying();
          input = int.Parse(Console.ReadLine());
          switch (input)
          {
            case 1:
              MakeMove(0, 0);
              break;
            case 2:
              MakeMove(0, 1);
              break;
            case 3:
              MakeMove(0, 2);
              break;
            case 4:
              MakeMove(1, 0);
              break;
            case 5:
              MakeMove(1, 1);
              break;
            case 6:
              MakeMove(1, 2);
              break;
            case 7:
              MakeMove(2, 0);
              break;
            case 8:
              MakeMove(2, 1);
              break;
            case 9:
              MakeMove(2, 2);
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
