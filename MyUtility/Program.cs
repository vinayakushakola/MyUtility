using System;
using Games.SnakeAndLadder;

namespace MyUtility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============ My Utility ============");

            SnakeAndLadder objSnakeAndLadder = new SnakeAndLadder();
            objSnakeAndLadder.StartGame();
            objSnakeAndLadder.RollAdie();
        }
    }
}
