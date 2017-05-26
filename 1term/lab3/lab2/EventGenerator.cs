using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace lab1
{
    public delegate void FeedingHandle(Feeder f, FoodEventArgs fargs);

    public class FoodEventArgs : EventArgs
    {
        public string drink;
        public int foodAmount;

        public FoodEventArgs (string drink, int foodAmount)
        {
            this.drink = drink;
            this.foodAmount = foodAmount;
        }

        public FoodEventArgs() : this (null, 0) { }

    }
    [DataContract]
    public class Feeder
    {
        public event FeedingHandle FeedingEvent;
        [DataMember]
        public string name;
        [DataMember]
        public int age;
        [DataMember]
        public string sex;

        public Feeder(string name)
        {
            this.name = name;
        }

        public Feeder(string name, int age, string sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        public void Feeding()
        {
            string drink;
            int foodAmount;
            FoodEventArgs fargs;

            try
            {
                Console.WriteLine("Enter the drink of animal: (For successful feeding, you should type 'Water')");
                drink = Console.ReadLine();

                Console.WriteLine("Enter the amount of food: ");
                foodAmount = Int32.Parse(Console.ReadLine());

                fargs = new FoodEventArgs(drink, foodAmount);
            }

            catch
            {
                fargs = new FoodEventArgs();
            }

            Console.WriteLine("Feeder {0} is feeding animals...\n", name);

            if (FeedingEvent != null)
            {
                FeedingEvent((Feeder)this, fargs);
            }
        }
    }

  
    public class BigZoo
    {
        public const int ANIMALS_AMOUNT = 2;
        
        Animal[] animals = new Animal[ANIMALS_AMOUNT];

        public BigZoo(Feeder feeder)
        {
            animals[0] = (new Cat(true));
            animals[1] = (new Hamster(true));

            for (int i = 0; i < ANIMALS_AMOUNT; i++)
            {
                feeder.FeedingEvent += new FeedingHandle(animals[i].Feed);
            }
        }
    }
    // Using "Clean code" rule 
    // Удаление и так понятных комментаривиев
    // Удаление избыточных комментариев

    public class SmallZoo
    {
        List<Animal> animals = new List<Animal>();

        public SmallZoo(Feeder feeder)
        {
            animals.Add(new Cat(true));

            foreach (Animal an in animals)
            {
                feeder.FeedingEvent += (f, fargs) => { an.Feed(f, fargs); };
            }
        }
    }
}


