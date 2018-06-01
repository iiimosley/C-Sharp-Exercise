using System;

namespace tictactoe
{
  class Board
  {
    public static string CurrentStatus = 
    $" {RowMatrix.Row1[0]} | {RowMatrix.Row1[1]} | {RowMatrix.Row1[2]} {Environment.NewLine} {RowMatrix.Row2[0]} | {RowMatrix.Row2[1]} | {RowMatrix.Row2[2]} {Environment.NewLine} {RowMatrix.Row3[0]} | {RowMatrix.Row3[1]} | {RowMatrix.Row3[2]} {Environment.NewLine}";

  }
}
