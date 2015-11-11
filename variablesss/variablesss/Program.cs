using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variablesss
{
    class Program
    {
        static void Main(string[] args)
        {   
            //initializing and assigning variables, "tostring" operation
            int first;
            int second;
            first = 7;
            second = first + 2;
            Console.WriteLine(second);
            Console.WriteLine(first);
            string myname;
            myname = "Ashley";

            string concatenate = first.ToString() + myname;
            Console.WriteLine(myname);
            Console.WriteLine(concatenate);
            Console.ReadLine();

        }
    }
}
