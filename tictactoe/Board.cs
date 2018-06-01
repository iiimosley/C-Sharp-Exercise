using System;

namespace tictactoe
{
  class Board
  {
    static string straightLine = new String('-', 11);
    public static string CurrentStatus = 
    $" {RowMatrix.Table[0][0]} | {RowMatrix.Table[0][1]} | {RowMatrix.Table[0][2]} {Environment.NewLine}{straightLine}{Environment.NewLine} {RowMatrix.Table[1][0]} | {RowMatrix.Table[1][1]} | {RowMatrix.Table[1][2]} {Environment.NewLine}{straightLine}{Environment.NewLine} {RowMatrix.Table[2][0]} | {RowMatrix.Table[2][1]} | {RowMatrix.Table[2][2]} {Environment.NewLine}";
  }
}
