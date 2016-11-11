using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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

    public class Feeder
    {
        public event FeedingHandle FeedingEvent;
        public string name;

        public Feeder(string name)
        {
            this.name = name;
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
    
    public class Zoo
    {
        List<Animal> animals = new List<Animal>();

        public Zoo(Feeder feeder)
        {
            animals.Add(new Cat(true));
            animals.Add(new Hamster(true));
            foreach (Animal an in animals)
                feeder.FeedingEvent += new FeedingHandle(an.Feed);
        }
    }
}


