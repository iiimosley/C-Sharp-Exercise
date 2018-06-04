using System;
using System.Linq;
using System.Collections.Generic;

namespace tictactoe
{
  class Determine
  {
    static char[][] WinningRows = new char[8][]
    {
      Matrix.Table[0],
      Matrix.Table[1],
      Matrix.Table[2],
      new char[] { Matrix.Table[0][0], Matrix.Table[1][0], Matrix.Table[2][0] },
      new char[] { Matrix.Table[0][1], Matrix.Table[1][1], Matrix.Table[2][1] },
      new char[] { Matrix.Table[0][2], Matrix.Table[1][2], Matrix.Table[2][2] },
      new char[] { Matrix.Table[0][0], Matrix.Table[1][1], Matrix.Table[2][2] },
      new char[] { Matrix.Table[0][2], Matrix.Table[1][1], Matrix.Table[2][0] },
    };

    public static bool Winner(char player) => WinningRows.Any(row => row.All(val => val == player));

  }
}