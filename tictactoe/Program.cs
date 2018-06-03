using System;

namespace tictactoe
{
    class Program
    {
        public static char CurrentPlayer = 'X';
        public static int printTable(string status)
        {
            Console.WriteLine(status);
            Console.WriteLine($"Current Player: {CurrentPlayer}");
            Console.Write("Mark a spot (1-9): ");
            return int.Parse(Console.ReadLine());
        }
        public static void Main()
        {
            try{
                int input = printTable(Board.CurrentStatus(RowMatrix.Table));
                Console.WriteLine(input);
                do 
                {
                    switch (input)
                    {
                        case 1:
                        {
                            Console.WriteLine($"You entered {input}");
                            RowMatrix.Table[0][0] = CurrentPlayer;
                            printTable(Board.CurrentStatus(RowMatrix.Table));
                            break;
                        }
                        case 2:
                        {
                            Console.WriteLine($"You entered {input}");
                            RowMatrix.Table[0][1] = CurrentPlayer;
                            printTable(Board.CurrentStatus(RowMatrix.Table));
                            break;
                        }
                        case 3:
                        {
                            Console.WriteLine($"You entered {input}");
                            RowMatrix.Table[0][2] = CurrentPlayer;
                            printTable(Board.CurrentStatus(RowMatrix.Table));
                            break;
                        }
                        case 4:
                        {
                            Console.WriteLine($"You entered {input}");
                            RowMatrix.Table[1][0] = CurrentPlayer;
                            printTable(Board.CurrentStatus(RowMatrix.Table));
                            break;
                        }
                        case 5:
                        {
                            Console.WriteLine($"You entered {input}");
                            RowMatrix.Table[1][1] = CurrentPlayer;
                            printTable(Board.CurrentStatus(RowMatrix.Table));
                            break;
                        }
                        case 6:
                        {
                            Console.WriteLine($"You entered {input}");
                            RowMatrix.Table[1][2] = CurrentPlayer;
                            printTable(Board.CurrentStatus(RowMatrix.Table));
                            break;
                        }
                        case 7:
                        {
                            Console.WriteLine($"You entered {input}");
                            RowMatrix.Table[2][0] = CurrentPlayer;
                            printTable(Board.CurrentStatus(RowMatrix.Table));
                            break;
                        }
                        case 8:
                        {
                            Console.WriteLine($"You entered {input}");
                            RowMatrix.Table[2][1] = CurrentPlayer;
                            printTable(Board.CurrentStatus(RowMatrix.Table));
                            break;
                        }
                        case 9:
                        {
                            Console.WriteLine($"You entered {input}");
                            RowMatrix.Table[2][2] = CurrentPlayer;
                            printTable(Board.CurrentStatus(RowMatrix.Table));
                            break;
                        }
                    }
                } while(input < 10 && input > 0);
            }
            catch(FormatException)
            {
                throw new System.FormatException();
            }
        }
    }
}
