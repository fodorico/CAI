using System.Diagnostics;
using ContactBook_v1 = ExerciseContactBook.main.entity.v1.ContactBook;
using Contact = ExerciseContactBook.main.entity.v1.Contact;

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
        Debug.Assert(cb.GetFrequentlyContact().toString() == "10", "Error Add calls! Expected: Calls: 10");

        cb.AddContact(c2);
        Debug.Assert(cb.GetFrequentlyContact().toString() == "11", "Error Add calls! Expected: Calls: 11");

        cb.DeleteContact(0);
        Debug.Assert(cb.GetFrequentlyContact().toString() == "11", "Error Add calls! Expected: Calls: 11");

        cb.AddContact(c1);
        cb.Contacts![1].AddCall();
        cb.Contacts![1].AddCall();
        Debug.Assert(cb.GetFrequentlyContact().toString() == "12", "Error Add calls! Expected: Calls: 12");
    }

    public static void Test_v2()
    {
        var c1 = new ContactPerson("Pepe", "E-pep", "Trap streets 0001", Convert.ToDateTime("10-01-2001"), 10);
        var c2 = new ContactCompany("Peppa", "Trap streets 0002", Convert.ToDateTime("20-02-2002"), 11);

        var cb = new ContactBook_v2("Contact", "Personal", c1);
        Debug.Assert(cb.GetFrequentlyContact().toString() == "10", "Error Add calls! Expected: Calls: 10");

        cb.AddContact(c2);
        Debug.Assert(cb.GetFrequentlyContact().toString() == "11", "Error Add calls! Expected: Calls: 11");

        cb.DeleteContact(0);
        Debug.Assert(cb.GetFrequentlyContact().toString() == "11", "Error Add calls! Expected: Calls: 11");

        cb.AddContact(c1);
        cb.Contacts![1].AddCall();
        cb.Contacts![1].AddCall();
        Debug.Assert(cb.GetFrequentlyContact().toString() == "12", "Error Add calls! Expected: Calls: 12");
    }
    
}