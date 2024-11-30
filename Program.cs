class Program
{
    static void Main()
    {
        // Create a dictionary where the key is the contact name (string) and the value is a Contato object
        Dictionary<string, Contato> contactList = new Dictionary<string, Contato>();

        // Declare a boolean variable used to control the program loop
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n---- Contact Manager ----");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Remove Contact");
            Console.WriteLine("3. Search Contact");
            Console.WriteLine("4. List All Contacts");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            // Read user input from the console, which corresponds to the menu option
            string option = Console.ReadLine()!;

            // Evaluate user input (option) and execute the corresponding method
            switch (option)
            {
                case "1":
                    AddContact(contactList);
                    break;
                case "2":
                    RemoveContact(contactList);
                    break;
                case "3":
                    SearchContact(contactList);
                    break;
                case "4":
                    ListAllContacts(contactList);
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    static void AddContact(Dictionary<string, Contato> contactList)
    {
        Console.WriteLine("Enter the name");
        string name = Console.ReadLine()!;

        // The ContainsKey() method checks if a contact with the entered name already exists
        if (contactList.ContainsKey(name))
        {
            Console.WriteLine("Contact already exists.");
            return;
        }

        Console.WriteLine("Enter the phone number");
        string phone = Console.ReadLine()!;

        Console.WriteLine("Enter the email");
        string email = Console.ReadLine()!;

        // Create a new Contato object and add it to the dictionary with the name as the key
        // This is where we create the first key with the added name
        // Example: {[Benício, {Name: Benício, Phone: 123456, Email: benicio@hotmail.com}}]}
        contactList[name] = new Contato(name, phone, email);
        Console.WriteLine("Contact added successfully.");
    }

    static void RemoveContact(Dictionary<string, Contato> contactList)
    {
        Console.WriteLine("Enter the name of the contact to be removed: ");
        string name = Console.ReadLine()!;

        if (contactList.Remove(name))
        {
            Console.WriteLine("Contact removed successfully.");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }

    static void SearchContact(Dictionary<string, Contato> contactList)
    {
        Console.WriteLine("Enter the name of the contact you want to search for: ");
        string name = Console.ReadLine()!;

        if (contactList.TryGetValue(name, out Contato? contact))
        {
            Console.WriteLine(contact);
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }

    static void ListAllContacts(Dictionary<string, Contato> contactList)
    {
        if (contactList.Count == 0)
        {
            Console.WriteLine("No contacts found.");
        }
        else
        {
            Console.WriteLine("\n--- Contact List ---");
            foreach (var contact in contactList.Values)
            {
                Console.WriteLine(contact);
            }
        }
    }
}