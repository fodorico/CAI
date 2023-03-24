namespace ExerciseConsole17;

public class Employee
{
    private string? Name { get; init; }
    public double Salary { get; init; }

    public Employee()
    {
    }
    
    public Employee(string name, double salary)
    {
        this.Name = name;
        this.Salary = salary;
    }

    public void Msg()
    {
        Console.WriteLine($"\nBest salary is for {Name} and his/her salary: {Salary}");
    }
}