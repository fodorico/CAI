namespace ExerciseContactBook.main.entity.v1;

public class ContactBook
{
    public string? Name { get; set; }
    public string? Type { get; set; }
    public List<Contact>? Contacts { get; } = new();
    public int MaxCountContacts { get; set; }

    public ContactBook()
    {
    }

    public ContactBook(string name, string type, Contact contacts, int maxCountContacts = 0)
    {
        Name = name;
        Type = type;
        Contacts!.Add(contacts);
        MaxCountContacts = maxCountContacts > 0 ? maxCountContacts : 9999;
    }

    public void AddContact(Contact c)
    {
        Contacts!.Add(c);
    }

    public void DeleteContact(int id)
    {
        Contacts!.Remove(Contacts[id]);
    }

    public Contact GetFrequentlyContact()
    {
        Contact? c = null;
        for (var i = 0; i < Contacts!.Count; i++)
        {
            c = i == 0 ? Contacts[i] : c!.Call >= Contacts[i].Call ? c : Contacts[i];
        }

        return c!;
    }
}