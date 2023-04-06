using ContactBook_v1 = ExerciseContactBook.main.entity.v1.ContactBook;
using Contact = ExerciseContactBook.main.entity.v1.Contact;
using AContact = ExerciseContactBook.main.abstraction.AContact;
using ContactBook_v2 = ExerciseContactBook.main.entity.v2.ContactBook;
using ContactPerson = ExerciseContactBook.main.entity.ContactPerson;
using ContactCompany = ExerciseContactBook.main.entity.ContactCompany;


namespace ExerciseContactBook.test;

public static class Test
{
    public static void Test_v1()
    {
        var c1 = new Contact("Pepe", "E-pep", "1234-5678", "Trap streets 0001", Convert.ToDateTime("10-01-2001"),
            10);
        var c2 = new Contact("Peppa", "A-pep", "9012-3456", "Trap streets 0002", Convert.ToDateTime("20-02-2002"),
            11);

        var cb = new ContactBook_v1("Contact", "Personal", c1);
        ConsoleShow_v1(cb);

        cb.AddContact(c2);
        ConsoleShow_v1(cb);

        cb.DeleteContact(0);
        ConsoleShow_v1(cb);

        cb.AddContact(c1);
        cb.Contacts![1].AddCall();
        cb.Contacts![1].AddCall();
        ConsoleShow_v1(cb);
    }

    private static void ConsoleShow_v1(ContactBook_v1 cb)
    {
        var c = cb.GetFrequentlyContact();
        Console.WriteLine(
            $"Full Name:{c.Name} {c.LastName}, Birthdate:{c.Birthdate:dd/MM/yy} ,Age:{c.GetAge()}, Number of calls:{c.Call}");
    }

    public static void Test_v2()
    {
        var c1 = new ContactPerson("Pepe", "E-pep", "Trap streets 0001", Convert.ToDateTime("10-01-2001"), 10);
        var c2 = new ContactCompany("Peppa", "Trap streets 0002", Convert.ToDateTime("20-02-2002"), 11);

        var cb = new ContactBook_v2("Contact", "Personal", c1);
        cb.GetFrequentlyContact().toString();

        cb.AddContact(c2);
        cb.GetFrequentlyContact().toString();

        cb.DeleteContact(0);
        cb.GetFrequentlyContact().toString();

        cb.AddContact(c1);
        cb.Contacts![1].AddCall();
        cb.Contacts![1].AddCall();
        cb.GetFrequentlyContact().toString();
    }
    
}