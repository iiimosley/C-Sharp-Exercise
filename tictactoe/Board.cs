using System;
using System.Collections.Generic;

namespace tictactoe
{
  class Board
  {
    static string straightLine = new String('-', 11);
    
    public static string CurrentStatus (char[][] AllRows)
    { 
    return $"{Environment.NewLine} {AllRows[0][0]} | {AllRows[0][1]} | {AllRows[0][2]} {Environment.NewLine}{straightLine}{Environment.NewLine} {AllRows[1][0]} | {AllRows[1][1]} | {AllRows[1][2]} {Environment.NewLine}{straightLine}{Environment.NewLine} {AllRows[2][0]} | {AllRows[2][1]} | {AllRows[2][2]} {Environment.NewLine}";
    }
  }
}
