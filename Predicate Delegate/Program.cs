namespace Predicate_Delegate
{
    internal class Program
    {
        static bool CanUnlockCharacter(int coins) => coins >= 100;

        static void Main()
        {
            Predicate<int> checkCoins = CanUnlockCharacter;
            Console.WriteLine($"Can unlock character: {checkCoins(120)}");
        }

    }
}
