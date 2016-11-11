using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Hamster : Animal, IAction
    {
        private bool isHungry;

        public Hamster (bool isHungry)
        {
            this.isHungry = isHungry;
        }

        public override void Feed(Feeder f, FoodEventArgs fargs)
        {
            if (isHungry)
            {
                makeSound();
                Console.WriteLine("Hamster is feeding by " + f.name);
                try
                {
                    Exceptions.ProcessFood(fargs.drink, fargs.foodAmount);
                    Exceptions.ProcessHamsterFood(fargs.foodAmount);
                }
                catch
                {
                    Console.WriteLine("It is incorrect amount of food for Hamster or incorrect drink");
                }
            }
            else
            {
                Console.WriteLine("I am not hungry");
            }
        }

        public void toSleep()
        {
            Age++;
            isHungry = true;
        }

        public void makeSound()
        {
            Console.WriteLine("FFFFFFFF");
        }
    }

}