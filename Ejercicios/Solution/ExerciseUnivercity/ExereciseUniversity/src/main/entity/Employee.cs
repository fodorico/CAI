using University.main.abstraction;

namespace University.main.entity;

public class Employee : APerson
{
    public DateTime AdmissionDate { get; set; }
    public int Code { get; set; }

    public List<Salary?>? Salaries { get; set; }

    public void AddSalary(Salary salary)
    {
        Salaries!.Add(salary);
    }

    public int GetSeniority()
    {
        return DateTime.Today.Year - AdmissionDate.Year;
    }

    public Salary? GetLastSalary()
    {
        return Salaries!.MaxBy(i => i!.DateSalary);
    }

    public override string? GetCredential()
    {
        return Code.ToString();
    }
}