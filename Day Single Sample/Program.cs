using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_Single_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello " + "World");
            Console.Write("What is your name");
            string yourName = Console.ReadLine();
            Console.WriteLine($"Hello {yourName}.");

            Console.Write("How many hours did you get last night? ");
            int hoursOfSleep = int.Parse(Console.ReadLine());
            
            if (hoursOfSleep >= 8)
            {
                Console.WriteLine("Good job. Thts allot of sleep!");
            }
            else if (hoursOfSleep >= 6)
            {
                Console.WriteLine("not bad but you need more sleep");
            }
            else if (hoursOfSleep < 6)
            {
                Console.WriteLine("dude you need more sleep");
            }
            else
            {
                Console.WriteLine("idk what you wrote");
            }
            Console.ReadKey();
        }
    }
}
