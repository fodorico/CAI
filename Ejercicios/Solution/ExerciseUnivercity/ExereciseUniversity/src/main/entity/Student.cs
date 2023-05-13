using University.main.abstraction;

namespace University.main.entity;

public class Student : APerson
{
    public string? Code { get; set; }
    public string? Credential { get; set; }
    
    public override string? GetCredential()
    {
        return Credential;
    }
}