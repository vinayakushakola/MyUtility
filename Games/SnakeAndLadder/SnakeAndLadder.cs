using System;

namespace Games.SnakeAndLadder
{
    public class SnakeAndLadder
    {
        public int PlayerPosition { get; private set; }
        private Random genRandomNum;
        public int DiceRolled { get; private set; }
        public int NoOfTimeDiceRolled { get; private set; }
        public bool IsLadder { get; private set; }

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
            IsLadder = false;
            // generates number 1 to 6
            DiceRolled = genRandomNum.Next(1, 7);
            NoOfTimeDiceRolled++;
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
                    DiceRolled = 0;
                    break;
                case typeOptions.Ladder:
                    // Increase player position by the dice rolled
                    PlayerPosition += DiceRolled;
                    IsLadder = true;
                    break;
                case typeOptions.SnakeBite:
                    // Decrease player position by the dice rolled
                    PlayerPosition -= DiceRolled;
                    break;
            }
            CheckPlayerPosition();
        }

        public bool CheckPlayerReached(SnakeAndLadder objPlayer)
        {
            if (objPlayer.PlayerPosition == 100)
                return true;
            return false;
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
