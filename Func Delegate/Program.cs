namespace Func_Delegate
{
    internal class Program
    {
        static int GetRemainingLives() => 3;

        static void Main()
        {
            Func<int> checkLives = GetRemainingLives;
            Console.WriteLine($"You have {checkLives()} lives left.");
        }

    }
}
