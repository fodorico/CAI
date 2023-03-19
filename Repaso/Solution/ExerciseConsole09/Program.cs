namespace ExerciseConsole09;

public static class Program
{
    private const bool Condition = true;
    private static readonly List<string> ListNames = new List<string>();

    public static void Main(string[] args)
    {
        while (Condition)
        {
            Console.Write("Write your name and press Enter: ");
            var input = Console.ReadLine();
            if (input != null && ListNames.Contains(input))
            {
                Console.WriteLine($"\n¡Hi, {input}");
            }
            else
            {
                Console.Write("\nI don't know you");
                Console.Write("\nDo you like add you in the list? (Yes/No)");
                var add = Console.ReadLine();
                if (input != null && add!.Equals("Yes"))
                {
                    ListNames.Add(input);
                }
            }

            Console.WriteLine("\nIf you want to finish, put \"Y\" ");
            var word = Console.ReadLine();
            if (word != null && word.ToUpper().Equals("Y"))
            {
                Environment.Exit(1);
            }
        }
    }
}