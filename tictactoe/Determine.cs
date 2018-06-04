using System;
using System.Collections.Generic;

namespace tictactoe
{
  class Determine
  {
    public static char[][] WinningRows = new char[8][]
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

  public static void RunRows()
  {
    for(int i=0; i<WinningRows.Length; i++)
    {
        Console.WriteLine(WinningRows[i]);
    }
  }
  
  }
}