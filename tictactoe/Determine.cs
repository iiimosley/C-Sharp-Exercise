using System;
using System.Linq;
using System.Collections.Generic;

namespace tictactoe
{
  class Determine
  {

    public static char Player(char player) => player == 'X' ? 'O' : 'X';

    static char[][] WinningRows (char[][] Table)
    {
      return new char[][] {
        Table[0],
        Table[1],
        Table[2],
        new char[] { Table[0][0], Table[1][0], Table[2][0] },
        new char[] { Table[0][1], Table[1][1], Table[2][1] },
        new char[] { Table[0][2], Table[1][2], Table[2][2] },
        new char[] { Table[0][0], Table[1][1], Table[2][2] },
        new char[] { Table[0][2], Table[1][1], Table[2][0] },
      };
    }

    public static bool Winner(char player) => WinningRows(Matrix.Table).Any(row => row.All(val => val == player));

  }
}