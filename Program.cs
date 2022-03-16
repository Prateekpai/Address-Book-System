using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();

                Console.Write("Enter First Name: ");
                person.FirstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                person.LastName = Console.ReadLine();

                Console.Write("Enter Phone Number: ");
                person.PhoneNumber = Console.ReadLine();
            
                Console.Write("Enter Email : ");
                person.Email = Console.ReadLine();

                Console.Write("Enter City : ");
                person.City = Console.ReadLine();

                Console.Write("Enter State : ");
                person.State = Console.ReadLine();

                Console.Write("Enter Zipcode : ");
                person.Zipcode = Console.ReadLine();

                Console.Write("Enter Address : ");
                person.Addresses = Console.ReadLine();

                Console.WriteLine("-------------------------------------------");

                Console.WriteLine("First Name: " + person.FirstName);
                Console.WriteLine("Last Name: " + person.LastName);
                Console.WriteLine("Phone Number: " + person.PhoneNumber);
                Console.WriteLine("Address : " + person.Addresses);
                Console.WriteLine("Address : " + person.Email);
                Console.WriteLine("Address : " + person.City);
                Console.WriteLine("Address : " + person.State);
                Console.WriteLine("Address : " + person.Zipcode);
                Console.WriteLine("-------------------------------------------");
        }
    }
}
