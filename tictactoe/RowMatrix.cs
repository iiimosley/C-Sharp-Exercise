using System;
using System.Collections.Generic;

namespace tictactoe
{
  class RowMatrix
  {
    public static List<List<char>> Main()
    {
      List<List<char>> Table = new List<List<char>>();
      for (int i = 0; i < 3; i++)
      {
        List<char> Row = new List<char>(new char[] { ' ', ' ', ' ' });
        Table.Add(Row);
      }
      return Table;
    }
  }
}
