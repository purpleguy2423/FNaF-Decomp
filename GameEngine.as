using System;

namespace FNaF
{
    public class GameEngine
    {
        public void RunGame()
        {
            Console.WriteLine("Game is starting...");
            // Additional game logic goes here
        }

        public void Initialize()
        {
            Console.WriteLine("Game is initializing...");
            // Initialization logic
        }

        public void Update()
        {
            Console.WriteLine("Game is updating...");
            // Update game state
        }

        public void Exit()
        {
            Console.WriteLine("Game is exiting...");
            // Cleanup logic
        }
    }
}