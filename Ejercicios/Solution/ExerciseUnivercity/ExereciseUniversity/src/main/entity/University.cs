namespace University.main.entity;

public class University
{
    public List<Student?>? Students { get; set; }
    public int CountCampuses { get; set; }
    public List<Employee?>? Employees { get; set; }
    public string? Name { get; set; }

    public void AddStudent(Student student)
    {
        Students!.Add(student);
    }

    public void AddEmployee(Employee employee)
    {
        Employees!.Add(employee);
    }

    public void DeleteStudent(Student student)
    {
        Students!.Remove(student);
    }

    public void DeleteEmployee(Employee employee)
    {
        Employees!.Remove(employee);
    }

    public void AlterEmployee(Employee employee)
    {
        DeleteEmployee(employee);
        AddEmployee(employee);
    }

    public Employee? GetEmployeeById(int id)
    {
        return Employees!.FirstOrDefault(n => n!.Code == id);
    }

    public List<Employee?> GetEmployeeByName(string name)
    {
        return Employees!.FindAll(n => n!.Name == name);
    }
}