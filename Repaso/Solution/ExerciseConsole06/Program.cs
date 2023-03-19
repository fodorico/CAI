namespace ExerciseConsole06;

public static class Program
{
    private const bool Condition = true;

    public static void Main(string[] args)
    {
        while (Condition)
        {
            var number = ValidateInfo();
            Console.WriteLine($"Result: {(number[0] + number[1]) * (number[0] - number[1])}");
            Console.WriteLine("\nIf you want to finish, put \"Y\" ");
            var word = Console.ReadLine();
            if (word != null && word.ToUpper().Equals("Y"))
            {
                Environment.Exit(1);
            }
        }
    }

    private static int[] ValidateInfo()
    {
        while (true)
        {
            Console.Write("Write two numbers and press Enter: ");
            var input = Console.ReadLine();
            if (input != null && input.Split(" ").Length == 2)
            {
                var splitInput = input.Split(" ");
                if (int.TryParse(splitInput[0], out var number0) && int.TryParse(splitInput[1], out var number1))
                {
                    return new[] { number0, number1 };
                }
            }

            Console.WriteLine("\nPlease write two number!");
        }
    }
}