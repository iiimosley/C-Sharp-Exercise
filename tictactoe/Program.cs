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
        static void Main()
        {
            try{
                int input = printTable(Board.CurrentStatus);
                do 
                {
                    switch (input)
                    {
                        case 1:
                        {
                            Console.WriteLine($"You entered {input}");
                            Board.Matrix[0][0] = CurrentPlayer;
                            printTable(Board.CurrentStatus);
                            break;
                        }
                        case 2:
                        {
                            Console.WriteLine($"You entered {input}");
                            Board.Matrix[0][1] = CurrentPlayer;
                            printTable(Board.CurrentStatus);
                            break;
                        }
                        case 3:
                        {
                            Console.WriteLine($"You entered {input}");
                            Board.Matrix[0][2] = CurrentPlayer;
                            printTable(Board.CurrentStatus);
                            break;
                        }
                        case 4:
                        {
                            Console.WriteLine($"You entered {input}");
                            Board.Matrix[1][0] = CurrentPlayer;
                            printTable(Board.CurrentStatus);
                            break;
                        }
                        case 5:
                        {
                            Console.WriteLine($"You entered {input}");
                            Board.Matrix[1][1] = CurrentPlayer;
                            printTable(Board.CurrentStatus);
                            break;
                        }
                        case 6:
                        {
                            Console.WriteLine($"You entered {input}");
                            Board.Matrix[1][2] = CurrentPlayer;
                            printTable(Board.CurrentStatus);
                            break;
                        }
                        case 7:
                        {
                            Console.WriteLine($"You entered {input}");
                            Board.Matrix[2][0] = CurrentPlayer;
                            printTable(Board.CurrentStatus);
                            break;
                        }
                        case 8:
                        {
                            Console.WriteLine($"You entered {input}");
                            Board.Matrix[2][1] = CurrentPlayer;
                            printTable(Board.CurrentStatus);
                            break;
                        }
                        case 9:
                        {
                            Console.WriteLine($"You entered {input}");
                            Board.Matrix[2][2] = CurrentPlayer;
                            printTable(Board.CurrentStatus);
                            break;
                        }
                    }
                } while(input < 10 && input < 0);
            }
            catch(FormatException)
            {
                throw new System.FormatException();
            }
        }
    }
}
