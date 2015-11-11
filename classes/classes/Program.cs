using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//playing with classes
namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dress LittleBlackDress = new Dress();

            LittleBlackDress.Make = "Lace";
            LittleBlackDress.Brand = "Valuntino";
            LittleBlackDress.Year = 2014;
            LittleBlackDress.Color = "Black";

            Console.WriteLine("{0} - {1}",
                LittleBlackDress.Make,
                LittleBlackDress.Brand
                );

            

            Console.WriteLine("Is the dress in fashion: {0:C}", LittleBlackDress.outoffashion());

            Console.ReadLine();
        }

       

        class Dress
        {
            public string Make { get; set; }
            public string Brand { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }

            public bool outoffashion()
            {
                bool fashion = false;

                if (this.Year > 2013)
                    fashion = true;
                

                return fashion;
            }

        }



    }
}
