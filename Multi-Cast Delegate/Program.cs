namespace Multi_Cast_Delegate
{
    internal class Program
    {
        public delegate void GameEvent();

        static void ShowScreen() => Console.WriteLine("Screen ON!");
        static void PlaySound() => Console.WriteLine("Welcome Sound Playing!");

        static void Main()
        {
            GameEvent powerButton = ShowScreen;
            powerButton += PlaySound;
            powerButton(); // Both methods triggered
        }
    }
}
