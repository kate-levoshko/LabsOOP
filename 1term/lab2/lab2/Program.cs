using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Feeder feeder = new Feeder("Katya");
            Zoo zoo = new Zoo(feeder);
            feeder.Feeding();

            Cat c = new lab1.Cat(false);
            Console.WriteLine("\nRacion of cat: \n");
            c.Racion();


            Console.ReadKey();
        }
    }

}
