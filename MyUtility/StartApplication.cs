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
                        SnakeAndLadder objPlayer1 = new SnakeAndLadder();
                        SnakeAndLadder objPlayer2 = new SnakeAndLadder();
                        objPlayer1.StartGame();
                        objPlayer2.StartGame();
                        while (objPlayer1.PlayerPosition < 100 || objPlayer2.PlayerPosition < 100)
                        {
                            if (objPlayer1.PlayerPosition == 100)
                            {
                                Console.WriteLine($"No of times dice rolled = {objPlayer1.NoOfTimeDiceRolled}");
                                Console.WriteLine("Player 1 Won");
                                break;
                            }
                            else if (objPlayer2.PlayerPosition == 100)
                            {
                                Console.WriteLine($"No of times dice rolled = {objPlayer2.NoOfTimeDiceRolled}");
                                Console.WriteLine("Player 2 Won");
                                break;
                            }
                            Player(ref objPlayer1);       // Player1
                            if (objPlayer1.PlayerPosition == 100) return;
                            Player(ref objPlayer2, true); // Player2
                        }
                        
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

        private static void Player(ref SnakeAndLadder objPlayer, bool IsPlayer2 = false)
        {
            int Player = IsPlayer2 ? 2 : 1;
            objPlayer.RollAdie();
            Console.WriteLine($"Die Rolled Player {Player} = {objPlayer.DiceRolled}");
            objPlayer.CheckOptions();
            if (objPlayer.IsLadder && objPlayer.PlayerPosition != 100)
            {
                objPlayer.RollAdie();
                Console.WriteLine($"Player {Player} Got Ladder");
                Console.WriteLine($"Die Rolled Player {Player} = {objPlayer.DiceRolled}");
            }
            Console.WriteLine($"Player {Player} Position = {objPlayer.PlayerPosition}");
        }
    }
}
