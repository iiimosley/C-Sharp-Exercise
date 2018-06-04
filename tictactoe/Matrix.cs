using System;
using System.Collections.Generic;

namespace tictactoe
{
  static class Matrix
  {
    public static char[][] Table = new char[3][];

    static Matrix()
    {
      for (int i = 0; i < Table.Length; i++)
      {
        Table[i] = new char[] { ' ', ' ', ' ' };
      }
    }

    public static void MarkSpot(int x, int y)
    {
      Table[x][y] = Program.CurrentPlayer;
      if (Determine.Winner(Program.CurrentPlayer))
        Prompt.Winner();
      else
        Program.CurrentPlayer = Determine.Player(Program.CurrentPlayer);
    }
  }
}
