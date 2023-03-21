namespace ExerciseConsole13;

public static class Program
{
    private const bool Condition = true;

    public static void Main(string[] args)
    {
        while (Condition)
        {
            var number = ValidateInfo();
            Console.WriteLine($"Result: {number}");
            
            Console.WriteLine("\nIf you want to finish, put \"Y\" ");
            var word = Console.ReadLine();
            if (word != null && word.ToUpper().Equals("Y"))
            {
                Environment.Exit(1);
            }
        }
    }

    private static int ValidateInfo()
    {
        while (true)
        {
            Console.Write("Write a number and press Enter: ");
            var input = Console.ReadLine();
            if (input != null && input.Trim().Length != 0)
            {
                if (int.TryParse(input, out var i))
                {
                    var number = 1;
                    for (var ii = 1; ii <= i; ii++)
                    {
                        number *= ii;
                    }
                    return number;
                }
            }

            Console.WriteLine("\nPlease write a number!");
        }
    }
}