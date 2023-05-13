namespace University.main.entity;

public class Salary
{
    public double GrossSalary { get; set; }
    public string? TransferCode { get; set; }
    public double Deduction { get; set; }
    public DateTime DateSalary { get; set; }

    public double GetNetSalary()
    {
        return GrossSalary - GrossSalary * 0.17;
    }
}