using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABP
{
    public class UC1
    {
        public void Address()
        {
            string FN = "Prateek";
            string LN = "Pai";
            string ADDR = "Bangalore";
            string City = "Bangalore";
            string Mob = "9945007207";
            string State = "Karnataka";
            int zip = 560027;
            string Email = "Prateekvasanthpai@gmail.com";
            {
                Console.WriteLine("First Name: " + FN);
                Console.WriteLine("Last Name: " + LN);
                Console.WriteLine("Address 1: " + ADDR);
                Console.WriteLine("City: " + City);
                Console.WriteLine("State: " + State);
                Console.WriteLine("Zip Code: " + zip);
                Console.WriteLine("Phone Number: " + Mob);
                Console.WriteLine("E-Mail: " + Email);
                Console.WriteLine("-------------------------------------------");
            }


        }
    }
}
