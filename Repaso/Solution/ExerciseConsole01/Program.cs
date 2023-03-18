namespace ExerciseConsole01;

public static class Program
{
    public static void Main(string[] args)
    {
        var registryNumber = 882831;
        for (var i = 1; i <= Math.Abs(registryNumber % 1000); i++)
        {
            var word = i % 3 == 0 && i % 5 == 0 ? $"{i} – FooBar" :
                i % 3 == 0 ? $"{i} – Foo" :
                i % 5 == 0 ? $"{i} – Bar" :
                $"{i}";

            Console.WriteLine(word);
        }

        Environment.Exit(1);
    }
}