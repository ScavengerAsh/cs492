using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//CONDITIONS AND SWITCHING
namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my name:");
            string input = Console.ReadLine();

            switch (input.ToUpper())
            {
                case "ASHLEY":
                    Console.WriteLine("CORRECT");
                    break;
                case "ASHLEY WANG":
                    Console.WriteLine("CORRECT");
                    break;
                case "YIKE WANG":
                    Console.WriteLine("CORRECT");
                    break;
                default:
                    Console.WriteLine("OOPS. WRONG ONE. ");
                    break;
            }


            Console.ReadLine();

        }
    }
}
