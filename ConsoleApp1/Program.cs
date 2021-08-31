using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Ninja");
            Console.WriteLine("Hello" + "Ninja");
            Console.WriteLine("What is your name? ");
            string yourName = Console.ReadLine();
            Console.WriteLine($"Hello {yourName}.");

            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();


            Console.Write("How many hours of sleep did you get last nite? ");
            int hoursOfSleep = int.Parse (Console.ReadLine());



            if (hoursOfSleep >= 8)
            {
                Console.WriteLine("Good job. Thats a lot of sleep.");
            }
            else if (hoursOfSleep >= 6)
            {
                Console.WriteLine("Not bad, but you need more.");
            }
            else if (hoursOfSleep > 6)
            {
                Console.WriteLine("You need more sleep.");
            }
            else
            {
                Console.Write("I dont know what you wrote.");
            }



            Console.ReadKey();
        }
    }
}
