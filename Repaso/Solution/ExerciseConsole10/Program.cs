namespace ExerciseConsole10;

public static class Program
{
    private const bool Condition = true;

    public static void Main(string[] args)
    {
        while (Condition)
        {
            Console.Write("Enter any Key: ");
            var key = Console.ReadKey().KeyChar;
            var keyString = key.ToString();
            if (char.IsLetter(key))
            {
                if ("aeiou".Contains(keyString.ToLower()))
                {
                    Console.WriteLine($"\n {keyString} is a vowel");
                }
                else
                {
                    Console.WriteLine($"\n {keyString} is a consonant");
                }
            }
            else if (int.TryParse(keyString, out _))
            {
                Console.WriteLine($"\n {keyString} is a number");
            }
            else
            {
                Console.WriteLine($"\n {keyString} is a symbol");
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