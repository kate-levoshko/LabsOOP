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
            Animal abAnimal = new Animal();
            abAnimal.Name = "Animal";
            abAnimal.Age = 10;
            abAnimal.toSleep();
            abAnimal.makeSound();
            abAnimal.toFeed();
            abAnimal.makeSound(); // must show a Message like "Animal is not hungry"
            Console.WriteLine("\n");

            Bird canary = new Bird("Julia", 5);
            canary.Age = 8; 
            canary.toSleep();
            canary.makeSound();
            canary.toFeed();
            canary.makeSound();
            Console.WriteLine("Info about Bird: {0}\n", canary);


            Cat kisa = new Cat("Murka", 2, true);
            kisa.mammalRacion();
            kisa.makeSound();
            Console.WriteLine("Info about Cat: {0}\n", kisa);

            Hamster homa = new Hamster("Katya", 1, false);
            homa.mammalRacion();
            homa.makeSound();
            homa.toFeed();
            Console.WriteLine("Info about Homster: {0}\n", homa);

            Vorona.createVorona("KAtya", 7, "Australia");

            abAnimal.animalAmount();

            Console.ReadLine();
        }
    }
}
