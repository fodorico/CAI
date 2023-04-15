namespace ExerciseContactBook.main.entity.v1;

public class Contact
{
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public string? Phone { get; set; }
    public string? Address { get; set; }
    public DateTime Birthdate { get; set; }
    public int Call { get; private set; }

    public Contact()
    {
    }

    public Contact(string? name, string? lastName, string? phone, string? address, DateTime birthdate, int call)
    {
        Name = name;
        LastName = lastName;
        Phone = phone;
        Address = address;
        Birthdate = birthdate;
        Call = call;
    }

    public void AddCall()
    {
        Call++;
    }

    public int GetAge()
    {
        var today = DateTime.Today;
        var age = today.Year - Birthdate.Year;
        return (Birthdate.Date > today.AddYears(-age)) ? age - 1 : age;
    }

    public string toString()
    {
        Console.WriteLine(
            $"Full Name:{Name} {LastName}, Birthdate:{Birthdate:dd/MM/yy} ,Age:{GetAge()}, Number of calls:{Call}");
        return Call.ToString();
    }
}