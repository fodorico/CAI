namespace University.main.abstraction;

public abstract class APerson
{
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public DateTime Birthdate { get; set; }

    public abstract string? GetCredential();

    public string GetFullName()
    {
        return $"FullName: {LastName}, {Name}";
    }

    public int Age()
    {
        return DateTime.Today.Year - Birthdate.Year;
    }
}