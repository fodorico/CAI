using System.Text;

namespace ExerciseConsole18;

public static class Program
{
    private const bool Condition = true;

    public static void Main(string[] args)
    {
        while (Condition)
        {
            var value = ValidateDouble();
            var binaryString = StringToBinary(value);
            var octalString = Convert.ToInt32(value, 8);
            var hexString = Convert.ToHexString(Encoding.UTF8.GetBytes(value));
            Console.WriteLine($"Input: {value}, Binary: {binaryString}, Octal:{octalString}, Hex: {hexString}");
            Console.WriteLine("\nIf you want to finish, put \"Y\" ");
            var word = Console.ReadLine();
            if (word != null && word.ToUpper().Equals("Y"))
            {
                Environment.Exit(1);
            }
        }
    }

    private static string StringToBinary(string value)
    {
        var binary = new StringBuilder();

        foreach (var c in value.ToCharArray())
        {
            binary.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
        }

        return binary.ToString();
    }

    private static string ValidateDouble()
    {
        while (true)
        {
            Console.Write("Write a number and press Enter: ");
            var input = Console.ReadLine();
            if (input != null && input.Trim().Length > 0 && double.TryParse(input, out _))
            {
                return input;
            }

            Console.WriteLine("Please, write something correct!");
        }
    }
}