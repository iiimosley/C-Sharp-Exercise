using System;
using System.Collections.Generic;

namespace tictactoe
{
  static class RowMatrix
  {
    public static char[][] Table = new char[3][];

    static RowMatrix()
    {
      for (int i = 0; i < Table.Length; i++)
      {
        Table[i] = new char[] { ' ', ' ', ' ' };
      }
    }
  }
}
