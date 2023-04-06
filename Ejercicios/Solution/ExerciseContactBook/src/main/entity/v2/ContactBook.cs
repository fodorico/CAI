using ExerciseContactBook.main.abstraction;

namespace ExerciseContactBook.main.entity.v2;

public class ContactBook
{
    public string? Name { get; set; }
    public string? Type { get; set; }
    public List<AContact>? Contacts { get; } = new();
    public int MaxCountContacts { get; set; }

    public ContactBook()
    {
    }

    public ContactBook(string name, string type, AContact contacts, int maxCountContacts = 0)
    {
        Name = name;
        Type = type;
        Contacts!.Add(contacts);
        MaxCountContacts = maxCountContacts > 0 ? maxCountContacts : 9999;
    }

    public void AddContact(AContact c)
    {
        Contacts!.Add(c);
    }

    public void DeleteContact(int id)
    {
        Contacts!.Remove(Contacts[id]);
    }

    public AContact GetFrequentlyContact()
    {
        AContact? c = null;
        for (var i = 0; i < Contacts!.Count; i++)
        {
            c = i == 0 ? Contacts[i] : c!.Call >= Contacts[i].Call ? c : Contacts[i];
        }

        return c!;
    }
}