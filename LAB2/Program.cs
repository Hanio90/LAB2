using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            Console.ReadLine();
            Console.WriteLine("Please enter a number between 1 and 100:");
            
            int Input = int.Parse(Console.ReadLine());         
            
            
            
                
                if (Input % 2 != 0 && Input >= 0)
                {
                    Console.WriteLine($"The number you entered is {Input} and is ODD");
                }

                else if (Input % 2 == 0 && Input < 25)
                {
                    Console.WriteLine($"The number you entered is even and less then 25");
                }
                else if (Input % 2 == 0 && Input >= 26 && Input <= 60)
                {
                    Console.WriteLine("Even");
                }

                else if (Input % 2 == 0 && Input > 60)
                {
                    Console.WriteLine($"The number you entered is {Input} and is EVEN");
                }
                else if (Input % 2 != 0 && Input > 60)
                {
                    Console.WriteLine($"The number you entered is {Input} and is ODD");
                }

                     Console.WriteLine("Continue? Y/N");
                     string response = Console.ReadLine();

                      if (response.ToLower() == "yes" || response.ToLower() == "y")
                     Main(args);

                     else
                     Console.WriteLine("Goodbye");




        }
    }
}
