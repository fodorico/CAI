namespace ExerciseConsole04;

public static class Program
{
    private const bool Condition = true;

    public static void Main(string[] args)
    {
        while (Condition)
        {
            var word = ValidateInfo();
            var firstWord = word!.Split(" ")[0].ToCharArray();
            var secondWord = word!.Split(" ")[1].ToCharArray();
            Array.Sort(firstWord);
            Array.Sort(secondWord);
            Console.WriteLine(new string(firstWord).Equals(new string(secondWord))
                ? "The word is Anagram"
                : "The word isn't Anagram");
            Console.WriteLine("\nIf you want to finish, put \"Y\" ");
            word = Console.ReadLine();
            if (word != null && word.ToUpper().Equals("Y"))
            {
                Environment.Exit(1);
            }
        }
    }

    private static string? ValidateInfo()
    {
        while (true)
        {
            var input = "";
            Console.Write("Write two words and press Enter: ");
            input = Console.ReadLine();
            if (input != null && input.Split(" ").Length == 2)
            {
                return input;
            }

            Console.WriteLine("\nPlease write two words!");
        }
    }
}