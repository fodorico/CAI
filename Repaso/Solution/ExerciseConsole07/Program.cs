namespace ExerciseConsole07;

public static class Program
{
    private const bool Condition = true;

    public static void Main(string[] args)
    {
        while (Condition)
        {
            var listNumber = ValidateInfo();
            var arrayNumber = GetMaxMinMixNumber(listNumber);
            Console.WriteLine($"Max: {arrayNumber[0]}; Min: {arrayNumber[1]}; Mix:{arrayNumber[2]}");
            Console.WriteLine("\nIf you want to finish, put \"Y\" ");
            var word = Console.ReadLine();
            if (word != null && word.ToUpper().Equals("Y"))
            {
                Environment.Exit(1);
            }
        }
    }

    private static int[] GetMaxMinMixNumber(List<int> listNumber)
    {
        listNumber.Sort();
        return new[] { listNumber[0], listNumber[2], listNumber[4] };
    }

    private static List<int> ValidateInfo()
    {
        while (true)
        {
            Console.Write("Write five numbers between spaces and press Enter: ");
            var input = Console.ReadLine();
            if (input != null && input.Split(" ").Length == 5)
            {
                var splitInput = input.Split(" ");
                var listInputNumber = new List<int>();
                for (var i = 0; i < splitInput.Length; i++)
                {
                    if (int.TryParse(splitInput[i], out var number))
                    {
                        listInputNumber.Add(number);
                    }
                    else
                    {
                        break;
                    }

                    if (i == splitInput.Length - 1)
                    {
                        return listInputNumber;
                    }
                }
            }

            Console.WriteLine("\nPlease write five numbers!");
        }
    }
}