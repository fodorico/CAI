namespace ExerciseConsole03;

public static class Program
{
    private const bool Condition = true;

    public static void Main(string[] args)
    {
        while (Condition)
        {
            var word = ValidateInfo();
            var arrayWord = word!.ToCharArray();
            Array.Reverse(arrayWord);
            var reverseWord = new string(arrayWord);
            Console.WriteLine(reverseWord.Equals(word) ? "The word is Palindrome" : "The word isn't Palindrome");
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
            Console.Write("Write a word and press Enter: ");
            input = Console.ReadLine();
            if (input != null && input.Trim().Length != 0)
            {
                return input;
            }

            Console.WriteLine("\nPlease write a word!");
        }
    }
}