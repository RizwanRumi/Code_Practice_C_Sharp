using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgramExample
{
    internal class SRPExample
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            //Ask for user information
            Person user = new Person();
            Console.WriteLine("What is your first name: ");
            user.FirstName = Console.ReadLine();

            Console.WriteLine("What is your Last name: ");
            user.LastName = Console.ReadLine();

            //Check to be sure the first and last names are valid
            if(string.IsNullOrWhiteSpace(user.FirstName))
            {
                Console.WriteLine("First name is not a valid format.");
                StandardMessages.EndApplication();
                return;
            }

            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                Console.WriteLine("Last name is not a valid format.");
                StandardMessages.EndApplication();
                return;
            }

            // Create a username for the person
            Console.WriteLine($"Your username is {user.FirstName}{user.LastName}");
            Console.ReadLine();
        }
    }
}