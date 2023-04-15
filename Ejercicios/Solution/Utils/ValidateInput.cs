using System.Globalization;

namespace Utils;

public static class ValidateInput
{
    public static string ValidateString(string text, string optional = "", string[]? list = null)
    {
        while (true)
        {
            Console.Write(text);
            var input = Console.ReadLine();
            if (input != null && input.Trim().Length > 0)
            {
                if ((optional.Length > 0 && list == null) ||
                    (optional == "IsLetterOrDigit" && input.All(char.IsLetterOrDigit) && list == null) ||
                    (optional == "IsLetter" && input.All(char.IsLetter) && list == null) ||
                    (OptionalList(input, list!))
                   )
                {
                    return input;
                }
            }

            Console.Clear();
            Console.WriteLine("Please, write something correct!");
        }
    }

    private static bool OptionalList(string text, string[] list)
    {
        return list.Aggregate(false, (current, v) => current ? current : v.Equals(text.ToLower()));
    }


    public static int ValidateInteger(string text, int min, int max, bool optional = false)
    {
        while (true)
        {
            Console.Write(text);
            var input = Console.ReadLine();
            if (input != null && input.Trim().Length > 0 && int.TryParse(input, out var result))
            {
                if (!optional || (min < result && result <= max))
                {
                    return result;
                }
            }

            Console.Clear();
            Console.WriteLine("Please, write something correct!");
        }
    }

    public static double ValidateDouble(string text)
    {
        while (true)
        {
            Console.Write(text);
            var input = Console.ReadLine();
            if (input != null && input.Trim().Length > 0 && double.TryParse(input, out var result))
            {
                return result;
            }

            Console.Clear();
            Console.WriteLine("Please, write something correct!");
        }
    }

    public static DateTime ValidateDateTime(string text)
    {
        while (true)
        {
            Console.Write(text);
            var input = Console.ReadLine();
            try
            {
                if (input != null)
                {
                    return DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Please, write something correct!");
            }
        }
    }
}