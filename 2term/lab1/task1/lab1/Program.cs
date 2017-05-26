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
            Felines animal1 = new BigPredators(80.0, 60.0, 4, "Africa", "Lion");
            Felines animal2 = new HomeAnimals("Kitty", 2.0, 0.15, 2, "Ukraine", "Cat");
            Lion lion = new Lion();
            Cat cat = new Cat();

            lion.connect(animal1);
            cat.connect(animal2);

            lion.toEat();
            lion.hunting();

            cat.playWithSun();
            cat.toSleep();

            cat.ShowInfo();
            lion.ShowInfo();

            Console.ReadKey();


        }
    }
}
