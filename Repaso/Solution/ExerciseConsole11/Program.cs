namespace ExerciseConsole11;

public static class Program
{
    private const bool Condition = true;
    private static List<Person> ListNames { get; } = new List<Person>();

    public static void Main(string[] args)
    {
        while (Condition)
        {
            FirstTime();
            var input = ValidateInfo();
            foreach (var person in ListNames.Where(person => person.Search(input[0], input[1], input[2])))
            {
                person.Msg();
            }

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
            var person = new Person(
                ValidateString("\nWrite your name and press Enter: "),
                ValidateString("Write your last name and press Enter: "),
                ValidateInteger("Write your age and press Enter: ")
            );
            ListNames.Add(person);
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

    private static string ValidateInteger(string text)
    {
        while (true)
        {
            Console.Write(text);
            var input = Console.ReadLine();
            if (input != null && input.Trim().Length > 0 && int.TryParse(input, out _))
            {
                return input;
            }

            Console.WriteLine("Please, write something correct!");
        }
    }

    private static string[] ValidateInfo()
    {
        while (true)
        {
            Console.Write("\nWrite your name, last name and your age between semicolon (\";\") and press Enter: ");
            var input = Console.ReadLine();
            if (input != null && input.Split(";").Length == 3)
            {
                var inputSplit = input.Split(";");
                var result = new string[3];
                for (var i = 0; i < inputSplit.Length; i++)
                {
                    var value = inputSplit[i];
                    if (value.Trim().Length == 0) break;
                    if (int.TryParse(value, out _) && string.IsNullOrEmpty(result[2]))
                    {
                        result[2] = value;
                    }
                    else if (int.TryParse(value, out _) && !string.IsNullOrEmpty(result[2]))
                    {
                        break;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(result[0]))
                        {
                            result[0] = value;
                        }
                        else if (string.IsNullOrEmpty(result[1]))
                        {
                            result[1] = value;
                        }
                    }


                    if (i == inputSplit.Length - 1)
                    {
                        return result;
                    }
                }
            }

            Console.WriteLine("\nPlease write your name, last name and your age only!");
        }
    }
}