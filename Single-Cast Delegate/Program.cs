namespace Single_Cast_Delegate
{
    internal class Program
    {
        public delegate void GameEvent();

        static void PauseGame()
        {
            Console.WriteLine("Game Paused!");
        }

        static void Main()
        {
            GameEvent pauseButton = PauseGame;
            pauseButton(); // Trigger Pause
        }
    }
}
