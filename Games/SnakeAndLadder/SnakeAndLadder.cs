using System;

namespace Games.SnakeAndLadder
{
    public class SnakeAndLadder
    {
        private int PlayerPosition;

        public void StartGame()
        {
            Console.WriteLine("\nSnake And Ladder Game");
            Console.WriteLine("Game Loading...");
            Console.WriteLine($"\nPlayer Position = {PlayerPosition}");
        }
    }
}
