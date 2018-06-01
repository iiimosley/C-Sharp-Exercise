using System;

namespace tictactoe
{
  class Board
  {
    static string straightLine = new String('-', 11);
    public static string CurrentStatus = 
    $" {RowMatrix.Main()[0][0]} | {RowMatrix.Main()[0][1]} | {RowMatrix.Main()[0][2]} {Environment.NewLine}{straightLine}{Environment.NewLine} {RowMatrix.Main()[1][0]} | {RowMatrix.Main()[1][1]} | {RowMatrix.Main()[1][2]} {Environment.NewLine}{straightLine}{Environment.NewLine} {RowMatrix.Main()[2][0]} | {RowMatrix.Main()[2][1]} | {RowMatrix.Main()[2][2]} {Environment.NewLine}";
  }
}
