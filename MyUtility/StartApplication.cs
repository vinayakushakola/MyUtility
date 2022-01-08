using System;
using Games;
using Games.SnakeAndLadder;

namespace MyUtility
{
    class StartApplication
    {
        internal static void Start()
        {
            Console.WriteLine("\nGames");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nSelect any choice");
                Console.WriteLine("1. Snake And Ladder");
                Console.WriteLine("2. Exit");
                int choice, count = 0;
                bool validChoice;
                do
                {
                    if (count > 0) Console.WriteLine("\nError : Invalid input\n\tPlease enter number");
                    Console.Write("Enter your choice = ");
                    validChoice = int.TryParse(Console.ReadLine(), out choice);
                    if (!validChoice) count++; 
                } while (!validChoice);


                switch ((typeGames)choice)
                {
                    case typeGames.SnakeAndLadder:
                        SnakeAndLadder objSnakeAndLadder = new SnakeAndLadder();
                        objSnakeAndLadder.StartGame();
                        while (objSnakeAndLadder.PlayerPosition < 100)
                        {
                            objSnakeAndLadder.RollAdie();
                            objSnakeAndLadder.CheckOptions();
                            Console.WriteLine($"Player Position = {objSnakeAndLadder.PlayerPosition}");
                        }
                        Console.WriteLine($"No of times dice rolled = {objSnakeAndLadder.NoOfTimeDiceRolled}");
                        break;
                    case typeGames.Exit:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine($"Enter choice between {typeGames.SnakeAndLadder.GetHashCode()} to {typeGames.Exit.GetHashCode()}");
                        break;

                }
            }
        }
    }
}
