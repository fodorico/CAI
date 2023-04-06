using ExerciseContactBook.main.abstraction;

namespace ExerciseContactBook.main.entity;

public class ContactPerson : AContact
{
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public DateTime Birthdate { get; set; }

    public ContactPerson(string? name, string? lastName, string? address, DateTime birthdate, int call)
    {
        Name = name;
        LastName = lastName;
        Address = address;
        Birthdate = birthdate;
        Call = call;
    }

    public int GetAge()
    {
        var today = DateTime.Today;
        var age = today.Year - Birthdate.Year;
        return (Birthdate.Date > today.AddYears(-age)) ? age - 1 : age;
    }
    
    public override void toString()
    {
        Console.WriteLine(
            $"Name:{Name} {LastName}, Time:{Birthdate:dd/MM/yy} ({GetAge()}), Number of calls:{Call}");
    }
}