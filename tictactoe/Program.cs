using System;

namespace tictactoe
{
    class Program
    {
        public static char CurrentPlayer = 'X';
        public static void markSpot(int x, int y)
        {
            RowMatrix.Table[x][y] = CurrentPlayer;
        }
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
                    markSpot(0, 0);
                else if(input == 2)
                    markSpot(0, 1);
                else if(input == 3)
                    markSpot(0, 2);
                else if(input == 4)
                    markSpot(1, 0);
                else if(input == 5)
                    markSpot(1, 1);
                else if(input == 6)
                    markSpot(1, 2);
                else if(input == 7)
                    markSpot(2, 0);
                else if(input == 8)
                    markSpot(2, 1);
                else if(input == 9)
                    markSpot(2, 2);
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
