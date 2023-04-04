using ExerciseContactBook.main.abstraction;

namespace ExerciseContactBook.main.entity;

public class ContactPerson : AContact
{
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public DateTime Birthdate { get; set; }

    public ContactPerson()
    {
    }

    public int GetAge()
    {
        var today = DateTime.Today;
        var age = today.Year - Birthdate.Year;
        return (Birthdate.Date > today.AddYears(-age)) ? age - 1 : age;
    }
}