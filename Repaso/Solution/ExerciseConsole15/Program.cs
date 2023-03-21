namespace ExerciseConsole15;

public static class Program
{
    private const bool Condition = true;
    private static readonly List<string> ListNames = new List<string>();

    public static void Main(string[] args)
    {
        var wrongPass = 0;
        while (Condition)
        {
            if (wrongPass < 3)
            {
                Console.Write("Write your password and press Enter: ");
                var input = Console.ReadLine();
                if (input != null && ListNames.Contains(input))
                {
                    Console.WriteLine($"\n¡Welcome, {input}!");
                }
                else
                {
                    Console.Write("\nAccess denied. The password is not correct");
                    Console.Write("\nDo you like add you in the list? (Yes/No)");
                    var add = Console.ReadLine();
                    if (input != null && add is "Yes")
                    {
                        ListNames.Add(input);
                        Console.WriteLine("User add!");
                    }

                    wrongPass++;
                }
            }
            else
            {
                Console.WriteLine("Password Locked");
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