using System;
using Games;
using Games.SnakeAndLadder;

namespace MyUtility
{
    class StartApplication
    {
        internal static void Start()
        {
            Console.WriteLine("\nSelect any choice");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nGames");
                Console.WriteLine("1. Snake And Ladder");
                Console.WriteLine("2. Exit");
                int choice;
                bool validChoice;
                do
                {
                    Console.Write("Enter your choice = ");
                    validChoice = int.TryParse(Console.ReadLine(), out choice);
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
                        break;
                    case typeGames.Exit:
                        flag = false;
                        break;

                }
            }
        }
    }
}
