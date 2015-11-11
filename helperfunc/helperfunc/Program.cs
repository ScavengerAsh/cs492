using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//helper function implementation
namespace helperfunc
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string myValue = HelperOne();
            int a = 10;
            int b = 11;
            int c = Adder(a, b);
            Console.WriteLine(c);
            Console.WriteLine(myValue);
            Console.ReadLine();
        }

        private static string HelperOne()
        {
            
            return "I am Ashley. I love cats.";
        }

        private static int Adder(int a, int b)
        {
            return a + b;

        }

    }
}
