namespace ExerciseConsole02;

public static class Program
{
    public static void Main(string[] args)
    {
        
        var registryNumber = 882831;
        for (var i = 1; i <= Math.Abs(registryNumber % 1000); i++)
        {
            var word = i % 3 == 0 && i % 2 != 0 ? $"{i} – Es primo y divisible por 3" :
                i % 3 == 0 ? $"{i} – Es divisible por 3" :
                i % 2 != 0 ? $"{i} – Es primo" :
                $"{i}";

            Console.WriteLine(word);
        }

        Environment.Exit(1);
    }
}