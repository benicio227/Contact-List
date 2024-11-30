# Contact Manager

This is a simple command-line program developed in **C#** that allows you to manage a contact list.  
The program offers functionalities to **add**, **remove**, **search**, and **list contacts**, using a **Dictionary** to store them efficiently.

### Features

- **Add Contact**: Allows adding a new contact with a name, phone number, and email.
- **Remove Contact**: Allows removing an existing contact by providing their name.
- **Search Contact**: Enables searching for a contact by name and displays the stored information.
- **List All Contacts**: Displays all the contacts registered in the system.

## Data Structure

Contacts are stored in a Dictionary where the key is the contact's name, and the value is an object of the `Contact` class.  
The `Contact` class contains the following properties: `Name`, `Phone`, and `Email`.

```json
{
    "Benício": {
        "Name": "Benício",
        "Phone": "123456789",
        "Email": "benicio@email.com"
    }
}
```

## Example Interaction

1. Add Contact

```sh
Enter the name: Benício
Enter the phone number: 82987514902
Enter the email: beniciobrandao@hotmail.com
Contact added successfully.
```
2. Search Contact

```sh
Enter the name of the contact you want to search for: Benício
Name: Benício
Phone: 82987514902
Email: beniciobrandao@hotmail.com
```

## Contribution

If you want to contribute to this project, follow the steps below:

- Fork this repository.
- Create a new branch (git checkout -b my-contribution).
- Make your changes and commit them (git commit -am 'Add my contribution').
- Push your changes to your fork (git push origin my-contribution).
- Open a Pull Request.
