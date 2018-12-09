using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_1_Basics_of_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            const int adultage = 18;

            string name = "Ola";
            var surname = "Rondarava";

            int age = 17;

            string[] documents = new string[]
            {
                "Application",
                "Permission"
            };

            if (age >= adultage)
            {
                Console.WriteLine($"{name} go to window 5");
            }
            else
            {
                bool hasPermission = documents.Contains("Permission");

                if (hasPermission)
                {
                    Console.WriteLine($"{name} go to window 5");
                    Console.WriteLine(name + " go to window 5");
                }
                else
                {
                    Console.WriteLine($"{name} go home");
                }
            }

            Console.ReadKey();
        }
    }
}
