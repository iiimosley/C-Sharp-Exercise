using System;
using System.Collections.Generic;

namespace tictactoe
{
  static class RowMatrix
  {
    public static List<List<char>> Table;
    static RowMatrix()
    {
      Table = new List<List<char>>();
      for (int i = 0; i < 3; i++)
      {
        List<char> Row = new List<char>(new char[] { ' ', ' ', ' ' });
        Table.Add(Row);
      }
    }
  }
}
