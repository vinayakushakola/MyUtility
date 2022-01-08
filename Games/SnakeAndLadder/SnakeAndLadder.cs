using System;

namespace Games.SnakeAndLadder
{
    public class SnakeAndLadder
    {
        public int PlayerPosition { get; private set; }
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
            Console.WriteLine($"\nInitial Player Position = {PlayerPosition}");
        }

        /// <summary>
        /// Method for rolling a die
        /// </summary>
        public void RollAdie()
        {
            // generates number 1 to 6
            DiceRolled = genRandomNum.Next(1, 7);
            Console.WriteLine($"Dice Rolled = {DiceRolled}");
        }

        /// <summary>
        /// Method for checking is snake or ladder or no play
        /// </summary>
        public void CheckOptions()
        {
            switch ((typeOptions)genRandomNum.Next(3))
            {
                case typeOptions.NO_Play:
                    // player stays at the same position
                    break;
                case typeOptions.Ladder:
                    // Increase player position by the dice rolled
                    PlayerPosition += DiceRolled;
                    break;
                case typeOptions.SnakeBite:
                    // Decrease player position by the dice rolled
                    PlayerPosition -= DiceRolled;
                    break;
            }
            CheckPlayerPosition();
        }

        private void CheckPlayerPosition()
        {
            if (PlayerPosition < 0)
                PlayerPosition = 0;
            else if (PlayerPosition > 100)
                PlayerPosition -= DiceRolled;
        }
    }
}
