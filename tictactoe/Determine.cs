using System;
using System.Linq;
using System.Collections.Generic;

namespace tictactoe
{
  class Determine
  {
    static char[][] WinningRows = new char[8][]
    {
      RowMatrix.Table[0],
      RowMatrix.Table[1],
      RowMatrix.Table[2],
      new char[] { RowMatrix.Table[0][0], RowMatrix.Table[1][0], RowMatrix.Table[2][0] },
      new char[] { RowMatrix.Table[0][1], RowMatrix.Table[1][1], RowMatrix.Table[2][1] },
      new char[] { RowMatrix.Table[0][2], RowMatrix.Table[1][2], RowMatrix.Table[2][2] },
      new char[] { RowMatrix.Table[0][0], RowMatrix.Table[1][1], RowMatrix.Table[2][2] },
      new char[] { RowMatrix.Table[0][2], RowMatrix.Table[1][1], RowMatrix.Table[2][0] },
    };

    public static bool Winner(char player) => WinningRows.Any(row => row.All(val => val == player));

  }
}