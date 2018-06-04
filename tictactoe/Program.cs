using System;

namespace tictactoe
{
    class Program
    {
        public static char CurrentPlayer = 'X';
        // public static void printTable(int x, int y)
        // {

        // }
        public static void Main()
        {
            try{
                int input;
                do {
                Console.WriteLine(Board.CurrentStatus(RowMatrix.Table));
                Console.WriteLine($"Current Player: {CurrentPlayer}");
                Console.Write("Mark a spot (1-9): ");
                input = int.Parse(Console.ReadLine());
                if(input == 1)
                    RowMatrix.Table[0][0] = CurrentPlayer;
                else if(input == 2)
                    RowMatrix.Table[0][1] = CurrentPlayer;
                else if(input == 3)
                    RowMatrix.Table[0][2] = CurrentPlayer;
                else if(input == 4)
                    RowMatrix.Table[1][0] = CurrentPlayer;
                else if(input == 5)
                    RowMatrix.Table[1][1] = CurrentPlayer;
                else if(input == 6)
                    RowMatrix.Table[1][2] = CurrentPlayer;
                else if(input == 7)
                    RowMatrix.Table[2][0] = CurrentPlayer;
                else if(input == 8)
                    RowMatrix.Table[2][1] = CurrentPlayer;
                else if(input == 9)
                    RowMatrix.Table[2][2] = CurrentPlayer;
                else
                    Console.WriteLine($"{input} is not a valid input");
                }while(input < 10);
            }
            catch(FormatException)
            {
                throw new System.FormatException();
            }
        }
    }
}
