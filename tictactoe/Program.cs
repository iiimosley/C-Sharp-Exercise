using System;

namespace tictactoe
{
    class Program
    {
        public static char CurrentPlayer = 'X';
        static void Main()
        {
            Console.WriteLine(Board.CurrentStatus);
            Console.WriteLine($"Current Player: {CurrentPlayer}");
            Console.Write("Mark a spot (1-9):");
            int input = int.Parse(Console.ReadLine());
            do 
            {
                switch (input)
                {
                    case 1:
                    {
                        Console.WriteLine($"You entered {input}");
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine($"You entered {input}");
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine($"You entered {input}");
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine($"You entered {input}");
                        break;
                    }
                    case 5:
                    {
                        Console.WriteLine($"You entered {input}");
                        break;
                    }
                    case 6:
                    {
                        Console.WriteLine($"You entered {input}");
                        break;
                    }
                    case 7:
                    {
                        Console.WriteLine($"You entered {input}");
                        break;
                    }
                    case 8:
                    {
                        Console.WriteLine($"You entered {input}");
                        break;
                    }
                    case 9:
                    {
                        Console.WriteLine($"You entered {input}");
                        break;
                    }
                }
            }while(input < 10 && input < 0);
        }
    }
}
