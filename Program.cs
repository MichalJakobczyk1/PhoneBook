using System;
using System.Collections.Generic;
using System.Linq;

//metoda wyświetl po numerze
//metoda wyświetl wszystkie + sortowanie
//metoda pokaż kontakt po nazwie

namespace PhoneBook
{
    class Program
    {
        //static Dictionary<string, Contact> GetContacts()
        //{
        //    return new Dictionary<string, Contact>
        //    {
        //        {"Marta",new Contact("Marta","516421882")},
        //        {"Darek",new Contact("Darek","779845671")},
        //        {"Ania",new Contact("Ania","456789121")},
        //        {"Marek",new Contact("Marek","678098667")},
        //        {"Danuta",new Contact("Danuta","432117980")},
        //        {"Piotr",new Contact("Piotr","523112786")},
        //        {"Czesio",new Contact("Czesio","898760112")},
        //        {"Michał",new Contact("Michał","672456989")},
        //        {"Gabi",new Contact("Gabi","765215678")},
        //        {"Patryk",new Contact("Patryk","442567812")},
        //    };
        //}

        static void ShowAllContacts(Dictionary<string, Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }
        static Dictionary<string, Contact> AddContact(Dictionary<string, Contact> contacts)
        {
            Console.WriteLine("Write new contact name:");
            string nameInput = Console.ReadLine();
            Console.WriteLine("Write new contact last name:");
            string lastNameInput = Console.ReadLine();
            Console.WriteLine("Write new contact number:");
            string numberInput = Console.ReadLine();

            contacts.Add(nameInput,new Contact(nameInput,lastNameInput,numberInput));

            return contacts;
        }
        static void Main(string[] args)
        {
            Dictionary<string, Contact> contacts = new Dictionary<string, Contact>
            {
                {"Marta",new Contact("Marta","Rozenek","516421882")},
                {"Darek",new Contact("Darek","Kowal","779845671")},
                {"Ania",new Contact("Ania","Adamczyk","456789121")},
                {"Marek",new Contact("Marek","Kowalski","678098667")},
                {"Danuta",new Contact("Danuta","Słowik","432117980")},
                {"Piotr",new Contact("Piotr","Jakóbczyk","523112786")},
                {"Czesio",new Contact("Czesio","Wawrzyniak","898760112")},
                {"Michał",new Contact("Michał","Owca","672456989")},
                {"Gabi",new Contact("Gabriela","Prus","765215678")},
                {"Patryk",new Contact("Patryk","Kołodziejczyk","442567812")},
            };

            Console.WriteLine("Hello in contact book, what you want to do?" +
                " \n 1. Show all contacts" +
                " \n 2. Add new contact");
            switch (Console.ReadLine())
            {
                case "1":
                    ShowAllContacts(contacts);
                    break;

                default: Console.WriteLine("Invalid instruction");
                    break;
            }
        }
    }
}
