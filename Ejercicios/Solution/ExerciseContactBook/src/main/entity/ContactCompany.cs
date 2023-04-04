using ExerciseContactBook.main.abstraction;

namespace ExerciseContactBook.main.entity;

public class ContactCompany : AContact
{
    public string? BusinessName { get; set; }
    public DateTime ConstructionDate { get; set; }

    public ContactCompany()
    {
    }

    public int GetAge()
    {
        var today = DateTime.Today;
        var age = today.Year - ConstructionDate.Year;
        return (ConstructionDate.Date > today.AddYears(-age)) ? age - 1 : age;
    }
}