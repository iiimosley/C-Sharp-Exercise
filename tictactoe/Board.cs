using System;
using System.Collections.Generic;

namespace tictactoe
{
  class Board
  {
    static string straightLine = new String('-', 11);
    public static List<List<char>> Matrix = RowMatrix.Table;
    public static string CurrentStatus = 
    $" {Matrix[0][0]} | {Matrix[0][1]} | {Matrix[0][2]} {Environment.NewLine}{straightLine}{Environment.NewLine} {Matrix[1][0]} | {Matrix[1][1]} | {Matrix[1][2]} {Environment.NewLine}{straightLine}{Environment.NewLine} {Matrix[2][0]} | {Matrix[2][1]} | {Matrix[2][2]} {Environment.NewLine}";
  }
}
