using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class Contact
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Number { get; set; }

        public Contact(string name, string lastName, string number)
        {
            if (name.Length > 1 && lastName.Length > 1)
            { 
                Name = name;
                LastName = lastName;
            }
            else
                Console.WriteLine("Name or last name is too short");

            if (number.Length == 9)
                Number = number;
            else if(number.StartsWith("0"))
                Console.WriteLine("Number must be 9 digits and cant start with 0");
        }

        public override string ToString()
        {
            return $"{Name} {LastName} {Number}";
        }
    }
}
