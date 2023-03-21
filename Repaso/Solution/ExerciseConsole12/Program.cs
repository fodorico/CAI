namespace ExerciseConsole12;

public static class Program
{
    private const bool Condition = true;

    public static void Main(string[] args)
    {
        while (Condition)
        {
            var diffDateTime = ValidateInfo();
            var initDate = new DateTime(1, 1, 1);
            var year = (initDate + diffDateTime).Year - 1;
            var months = (initDate + diffDateTime).Month - 1;
            var days = (initDate + diffDateTime).Day;
            Console.WriteLine($"The diff is {year} years, {months} months y {days} days”");

            Console.WriteLine("\nIf you want to finish, put \"Y\" ");
            var word = Console.ReadLine();
            if (word != null && word.ToUpper().Equals("Y"))
            {
                Environment.Exit(1);
            }
        }
    }

    private static TimeSpan ValidateInfo()
    {
        while (true)
        {
            Console.Write("Write two dates(DD/MM/YY) between spaces and press Enter: ");
            var input = Console.ReadLine();
            try
            {
                if (input == null || input.Split(" ").Length != 2) throw new Exception() ;
                var firstDate = DateTime.Parse(input.Split(" ")[0]);
                var secondDate = DateTime.Parse(input.Split(" ")[1]);
                return secondDate - firstDate;
            }
            catch (Exception)
            {
                Console.WriteLine("\nPlease write two dates!");
            }
        }
    }
}