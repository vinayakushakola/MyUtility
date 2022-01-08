using System;

namespace Games.SnakeAndLadder
{
    public class SnakeAndLadder
    {
        private int PlayerPosition;
        private Random genRandomNum;
        private int DiceRolled;

        public SnakeAndLadder()
        {
            genRandomNum = new Random();
        }

        /// <summary>
        /// Method to start snake and ladder game
        /// </summary>
        public void StartGame()
        {
            Console.WriteLine("\nSnake And Ladder Game");
            Console.WriteLine("Game Loading...");
            Console.WriteLine($"\nPlayer Position = {PlayerPosition}");
        }

        /// <summary>
        /// Method for rolling a die
        /// </summary>
        public void RollAdie()
        {
            // generates number 0 to 6
            DiceRolled = genRandomNum.Next(7);
            Console.WriteLine($"Dice Rolled = {DiceRolled}");
        }
    }
}
