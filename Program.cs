using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    class Program
    {
        static void ShowAllContacts(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }

        static void SortContacts(List<Contact> contacts)
        {
            List<Contact> SortedContacts = contacts.OrderBy(o => o.LastName).ToList();
            foreach (var contact in SortedContacts)
            {
                Console.WriteLine(contact);
            }
        }
        static List<Contact> AddContact(List<Contact> contacts)
        {
            Console.WriteLine("Write new contact name:");
            string nameInput = Console.ReadLine();
            Console.WriteLine("Write new contact last name:");
            string lastNameInput = Console.ReadLine();
            Console.WriteLine("Write new contact number:");
            string numberInput = Console.ReadLine();

            contacts.Add(new Contact(nameInput,lastNameInput,numberInput));

            return contacts;
        }
        static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>
            {
                {new Contact("Marta","Rozenek","516421882")},
                {new Contact("Darek","Kowal","779845671")},
                {new Contact("Ania","Adamczyk","456789121")},
                {new Contact("Marek","Kowalski","678098667")},
                {new Contact("Danuta","Słowik","432117980")},
                {new Contact("Piotr","Jakóbczyk","523112786")},
                {new Contact("Czesio","Wawrzyniak","898760112")},
                {new Contact("Michał","Owca","672456989")},
                {new Contact("Gabriela","Prus","765215678")},
                {new Contact("Patryk","Kołodziejczyk","442567812")},
            };

            menu:
            Console.WriteLine("Welcome in contact book, what you want to do?" +
                " \n 1. Show all contacts" +
                " \n 2. Show all contacts sorted" +
                " \n 3. Add new contact" +
                " \n 4. Search by number " +
                " \n 5. Search by name \n " +
                "6. Exit");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine();
                    ShowAllContacts(contacts);
                    Console.WriteLine("\n --------------------- \n");
                    goto menu;
                case "2":
                    Console.WriteLine();
                    SortContacts(contacts);
                    Console.WriteLine("\n --------------------- \n");
                    goto menu;
                case "3":
                    Console.WriteLine();
                    AddContact(contacts);
                    Console.WriteLine();
                    ShowAllContacts(contacts);
                    Console.WriteLine("\n --------------------- \n");
                    goto menu;
                case "4":
                    Console.WriteLine();
                    Console.WriteLine("Write number");
                    string inputNumber = Console.ReadLine();
                    Contact ShowByNumber = contacts.FirstOrDefault(c => c.Number == inputNumber);
                    Console.WriteLine(ShowByNumber);
                    Console.WriteLine("\n --------------------- \n");
                    goto menu;
                case "5":
                    Console.WriteLine();
                    Console.WriteLine("Write name");
                    string inputName = Console.ReadLine();
                    Contact ShowByName = contacts.FirstOrDefault(c => c.Name == inputName);
                    Console.WriteLine(ShowByName);
                    Console.WriteLine("\n --------------------- \n");
                    goto menu;
                case "6":
                    Console.WriteLine();
                    Console.WriteLine("Goodbye");
                    Environment.Exit(1);
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Invalid instruction");
                    break;
            }
        }
    }
}
