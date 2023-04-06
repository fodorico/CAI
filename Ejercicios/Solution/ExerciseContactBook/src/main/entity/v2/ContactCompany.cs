using ExerciseContactBook.main.abstraction;

namespace ExerciseContactBook.main.entity;

public class ContactCompany : AContact
{
    public string? BusinessName { get; set; }
    public DateTime ConstructionDate { get; set; }

    public ContactCompany(string? businessName, string? address, DateTime constructionDate, int call)
    {
        BusinessName = businessName;
        Address = address;
        ConstructionDate = constructionDate;
        Call = call;
    }

    public int GetAge()
    {
        var today = DateTime.Today;
        var age = today.Year - ConstructionDate.Year;
        return (ConstructionDate.Date > today.AddYears(-age)) ? age - 1 : age;
    }


    public override void toString()
    {
        Console.WriteLine(
            $"Name:{BusinessName}, Time:{ConstructionDate:dd/MM/yy} ({GetAge()}), Number of calls:{Call}");
    }
}