using System;

namespace tictactoe
{
    class Program
    {
        public static char CurrentPlayer = 'X';
        public static void printTable(string status)
        {
            Console.WriteLine(status);
            Console.WriteLine($"Current Player: {CurrentPlayer}");
            Console.Write("Mark a spot (1-9): ");
        }
        public static void Main()
        {
            try{
                int input;
                do {
                printTable(Board.CurrentStatus(RowMatrix.Table));
                input = int.Parse(Console.ReadLine());
                if(input == 1)
                {
                    Console.WriteLine($"You entered {input}");
                    RowMatrix.Table[0][0] = CurrentPlayer;
                    //printTable(Board.CurrentStatus(RowMatrix.Table));
                    // input = int.Parse(Console.ReadLine());
                }
                else if(input == 2)
                {
                    Console.WriteLine($"You entered {input}");
                    RowMatrix.Table[0][1] = CurrentPlayer;
                    //printTable(Board.CurrentStatus(RowMatrix.Table));
                    // input = int.Parse(Console.ReadLine());
                }
                else if(input == 3)
                {
                    Console.WriteLine($"You entered {input}");
                    RowMatrix.Table[0][2] = CurrentPlayer;
                    //printTable(Board.CurrentStatus(RowMatrix.Table));
                    // input = int.Parse(Console.ReadLine());
                }
                else if(input == 4)
                {
                    Console.WriteLine($"You entered {input}");
                    RowMatrix.Table[1][0] = CurrentPlayer;
                    //printTable(Board.CurrentStatus(RowMatrix.Table));
                    // input = int.Parse(Console.ReadLine());
                }
                else if(input == 5)
                {
                    Console.WriteLine($"You entered {input}");
                    RowMatrix.Table[1][1] = CurrentPlayer;
                    //printTable(Board.CurrentStatus(RowMatrix.Table));
                    // input = int.Parse(Console.ReadLine());
                }
                else if(input == 6)
                {
                    Console.WriteLine($"You entered {input}");
                    RowMatrix.Table[1][2] = CurrentPlayer;
                    //printTable(Board.CurrentStatus(RowMatrix.Table));
                    // input = int.Parse(Console.ReadLine());
                }
                else if(input == 7)
                {
                    Console.WriteLine($"You entered {input}");
                    RowMatrix.Table[2][0] = CurrentPlayer;
                    //printTable(Board.CurrentStatus(RowMatrix.Table));
                    // input = int.Parse(Console.ReadLine());
                }
                else if(input == 8)
                {
                    Console.WriteLine($"You entered {input}");
                    RowMatrix.Table[2][1] = CurrentPlayer;
                    //printTable(Board.CurrentStatus(RowMatrix.Table));
                    // input = int.Parse(Console.ReadLine());
                }
                else if(input == 9)
                {
                    Console.WriteLine($"You entered {input}");
                    RowMatrix.Table[2][2] = CurrentPlayer;
                    //printTable(Board.CurrentStatus(RowMatrix.Table));
                    // input = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine($"{input} is not a valid input");
                    //printTable(Board.CurrentStatus(RowMatrix.Table));
                }
                }while(input < 10);
            }
            catch(FormatException)
            {
                throw new System.FormatException();
            }
        }
    }
}
