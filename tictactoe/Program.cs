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
            Console.ReadLine();
        }
    }
}
