using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class Program
    {
        //time and date
        static void Main(string[] args)
        {
            DateTime time = DateTime.Now;
            
            DateTime Bday = DateTime.Parse("4/20/1994");
            TimeSpan age = DateTime.Now.Subtract(Bday);
            Console.WriteLine(time.ToString());
            Console.WriteLine(age.TotalDays);

            Console.ReadLine();
        }
    }
}
