using Utils;
using ContactBook_v1 = ExerciseContactBook.main.entity.v1.ContactBook;
using Contact = ExerciseContactBook.main.entity.v1.Contact;
using ContactBook_v2 = ExerciseContactBook.main.entity.v2.ContactBook;
using ContactPerson = ExerciseContactBook.main.entity.ContactPerson;
using ContactCompany = ExerciseContactBook.main.entity.ContactCompany;

namespace ExerciseContactBook.main;

public static class Program
{
    private const int WaitTime = 5000;
    private const string MenuRetain = "|-----------------------------|\n ";
    private const string MenuStatic = "0) Exit\n 1) Add Contact\n ";
    private const string MenuExtend = "2) Call Contact\n 3) Bring Frequent Contact\n";
    private static readonly ContactBook_v1 CbV1 = new();
    private static readonly ContactBook_v2 CbV2 = new();

    public static void Main()
    {
        var option = -1;
        while (true)
        {
            Console.Clear();
            option = option < 0 ? InitMenu() : Menu();
            SwitchMenu(option);
        }
    }

    private static void SwitchMenu(int option)
    {
        switch (option)
        {
            case 1:
                AddContact();
                break;
            case 2:
                CallContact();
                break;
            case 3:
                BringFrequentContact();
                Thread.Sleep(WaitTime);
                break;
            default:
                Console.Clear();
                Environment.Exit(1);
                break;
        }
    }

    private static int InitMenu()
    {
        Console.Write(MenuRetain + MenuStatic + MenuRetain);
        return ValidateInput.ValidateInteger("Option: ", -1, 1, true);
    }

    private static int Menu()
    {
        Console.Write(MenuRetain + MenuStatic + MenuExtend + MenuRetain);
        return ValidateInput.ValidateInteger("Option: ", -1, 3, true);
    }

    private static void AddContact()
    {
        if (ValidateInput.ValidateString("V1 or V2: ", "IsLetter", new[] { "v1", "v2" }).ToLower() == "v1")
        {
            CbV1.AddContact(
                new Contact(
                    ValidateInput.ValidateString("Name: ", "IsLetter"),
                    ValidateInput.ValidateString("Last Name: ", "IsLetter"),
                    ValidateInput.ValidateInteger("Phone: ", 10000000, 1599999999, true).ToString(),
                    ValidateInput.ValidateString("Address: ", "IsLetterOrDigit"),
                    ValidateInput.ValidateDateTime("Birthdate (DD-MM-YYYY): "),
                    0
                ));
        }
        else
        {
            if (ValidateInput.ValidateString("Person or Company: ", "IsLetter", new[] { "person", "company" })
                    .ToLower() == "person")
            {
                CbV2.AddContact(
                    new ContactPerson(
                        ValidateInput.ValidateString("Name: ", "IsLetter"),
                        ValidateInput.ValidateString("Last Name: ", "IsLetter"),
                        ValidateInput.ValidateString("Address: ", "IsLetterOrDigit"),
                        ValidateInput.ValidateDateTime("Birthdate (DD-MM-YYYY): "),
                        0
                    )
                );
            }
            else
            {
                CbV2.AddContact(
                    new ContactCompany(
                        ValidateInput.ValidateString("Name of Company: ", "IsLetter"),
                        ValidateInput.ValidateString("Address: ", "IsLetterOrDigit"),
                        ValidateInput.ValidateDateTime("Birthdate (DD-MM-YYYY): "),
                        0
                    )
                );
            }
        }
    }

    private static void CallContact()
    {
        if (ValidateInput.ValidateString("v1 or v2: ", "IsLetter", new[] { "v1", "v2" }).ToLower() == "v1")
        {
            var idContact = ValidateInput.ValidateInteger("Contact ID: ", 0, CbV1.Contacts!.Count, true);
            CbV1.Contacts[idContact <= 0 ? idContact - 1 : 0].AddCall();
        }
        else
        {
            var idContact = ValidateInput.ValidateInteger("Contact ID: ", 0, CbV1.Contacts!.Count, true);
            CbV2.Contacts![idContact <= 0 ? idContact - 1 : 0].AddCall();
        }
    }

    private static void BringFrequentContact()
    {
        if (ValidateInput.ValidateString("v1 or v2: ", "IsLetter", new[] { "v1", "v2" }).ToLower() == "v1")
        {
            var _ = CbV1.GetFrequentlyContact().toString();
        }
        else
        {
            var _ = CbV2.GetFrequentlyContact().toString();
        }

        Console.WriteLine($"\nIn {WaitTime / 1000} sec the console will clear");
    }
}