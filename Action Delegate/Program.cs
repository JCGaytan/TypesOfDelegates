namespace Action_Delegate
{
    internal class Program
    {
        static void SaveGame() => Console.WriteLine("Game Saved!");

        static void Main()
        {
            Action saveButton = SaveGame;
            saveButton();
        }

    }
}
