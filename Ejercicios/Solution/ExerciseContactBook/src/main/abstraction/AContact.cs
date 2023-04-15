namespace ExerciseContactBook.main.abstraction;

public abstract class AContact
{
    public int Id { get; set; }
    public string? Address { get; set; }
    public int Call { get; set; }

    public void AddCall()
    {
        Call++;
    }

    public abstract string toString();
}