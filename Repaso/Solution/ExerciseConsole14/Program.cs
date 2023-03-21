using System.Text;

namespace ExerciseConsole14;

public static class Program
{
    private const bool Condition = true;

    public static void Main(string[] args)
    {
        while (Condition)
        {
            var number = ValidateInfo();
            Console.WriteLine($"Table: \n{number}");
            
            Console.WriteLine("If you want to finish, put \"Y\" ");
            var word = Console.ReadLine();
            if (word != null && word.ToUpper().Equals("Y"))
            {
                Environment.Exit(1);
            }
        }
    }

    private static string ValidateInfo()
    {
        while (true)
        {
            Console.Write("Write a number and press Enter: ");
            var input = Console.ReadLine();
            if (input != null && input.Trim().Length != 0)
            {
                if (int.TryParse(input, out var i))
                {
                    var text = new StringBuilder();
                    for (var ii = 1; ii <= 10; ii++)
                    {
                        text.AppendLine($"{i}*{ii}= {i * ii}");
                    }
                    return text.ToString();
                }
            }

            Console.WriteLine("\nPlease write a number!");
        }
    }
}