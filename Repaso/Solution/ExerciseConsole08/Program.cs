namespace ExerciseConsole08;

public static class Program
{
    private const bool Condition = true;

    public static void Main(string[] args)
    {
        while (Condition)
        {
            var listDateTime = DateTime.Now - ValidateInfo();
            Console.WriteLine($"Diff between that date and today is {listDateTime.Days}");
            Console.WriteLine("\nIf you want to finish, put \"Y\" ");
            var word = Console.ReadLine();
            if (word != null && word.ToUpper().Equals("Y"))
            {
                Environment.Exit(1);
            }
        }
    }

    private static DateTime ValidateInfo()
    {
        while (true)
        {
            Console.Write("Write a date(DD/MM/YY) between spaces and press Enter: ");
            var input = Console.ReadLine();
            try
            {
                if (input != null)
                {
                    return DateTime.Parse(input);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nPlease write five numbers!");
            }
        }
    }
}