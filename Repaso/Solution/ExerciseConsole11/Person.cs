namespace ExerciseConsole11;

public class Person
{
    private readonly string _name;
    private readonly string _lastName;
    private readonly string _age;

    public Person(string name, string lastName, string age)
    {
        this._name = name;
        this._lastName = lastName;
        this._age = age;
    }

    public void Msg()
    {
        Console.WriteLine($"\nName: {_name}, Last Name: {_lastName}, Age: {_age}");
    }

    public bool Search(string v1, string v2, string v3)
    {
        return (
            (v1.Equals(_name) || v1.Equals(_lastName)) &&
            (v2.Equals(_name) || v2.Equals(_lastName)) &&
            v3.Equals(_age)
        );
    }
}