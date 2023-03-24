namespace ExerciseConsole17;

public static class Program
{
    private const bool Condition = true;
    private static readonly List<Employee> ListEmployees = new();

    public static void Main(string[] args)
    {
        while (Condition)
        {
            FirstTime();
            ListEmployees.OrderByDescending(x => x.Salary).First().Msg();
            Console.WriteLine("\nIf you want to finish, put \"Y\" ");
            var word = Console.ReadLine();
            if (word != null && word.ToUpper().Equals("Y"))
            {
                Environment.Exit(1);
            }
        }
    }

    private static void FirstTime()
    {
        Console.Write("Do you wanna add new info? press Y/N: ");
        var input = Console.ReadKey().KeyChar.ToString().ToUpper();
        if (input.Equals("Y"))
        {
            var employeeAdd = ValidateInteger("\nHow many employee do you like to add? ");
            for (var i = 0; i < employeeAdd; i++)
            {
                var employee = new Employee(
                    ValidateString("\nWrite your name and press Enter: "),
                    ValidateDouble("Write your salary and press Enter: ")
                );
                ListEmployees.Add(employee);
            }
        }
    }

    private static string ValidateString(string text)
    {
        while (true)
        {
            Console.Write(text);
            var input = Console.ReadLine();
            if (input != null && input.Trim().Length > 0)
            {
                return input;
            }

            Console.WriteLine("Please, write something correct!");
        }
    }

    private static int ValidateInteger(string text)
    {
        while (true)
        {
            Console.Write(text);
            var input = Console.ReadLine();
            if (input != null && input.Trim().Length > 0 && int.TryParse(input, out var result))
            {
                return result;
            }

            Console.WriteLine("Please, write something correct!");
        }
    }

    private static double ValidateDouble(string text)
    {
        while (true)
        {
            Console.Write(text);
            var input = Console.ReadLine();
            if (input != null && input.Trim().Length > 0 && double.TryParse(input, out var result))
            {
                return result;
            }

            Console.WriteLine("Please, write something correct!");
        }
    }
}