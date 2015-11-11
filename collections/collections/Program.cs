using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Toy doll = new Toy();
            doll.Make = "rubber";
            doll.Model = "barbie";
            doll.Name = "Elsa";

            Toy car = new Toy();
            car.Make = "plastic";
            car.Model = "BMW";
            car.Name = "SPUR";



            System.Collections.ArrayList myArrayList = new System.Collections.ArrayList();
            myArrayList.Add(doll);
            myArrayList.Add(car);




            System.Collections.Specialized.ListDictionary myDictionary
                = new System.Collections.Specialized.ListDictionary();

            myDictionary.Add(doll.Name, doll);
            myDictionary.Add(car.Name, car);
            foreach (object o in myArrayList)
            {
                Console.WriteLine(((Toy)o).Name);
            }



            Console.WriteLine(((Toy)myDictionary["Elsa"]).Model);
            Console.ReadLine();
             
        }

        class Toy
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public string Name { get; set; }
        }

    }
}
