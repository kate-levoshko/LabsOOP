using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Cat : Animal, IRacion, IAction
    {
        private bool isHungry;
        Food<String> racion = new Food<String>(new String[]{ "meat", "milk", "fish"});

        public Cat(bool isHungry)
        {
            this.isHungry = isHungry;
        }
        
        public override void Feed(Feeder f, FoodEventArgs fargs)
        {
            if (isHungry)
            {
                makeSound();
                Console.WriteLine("Cat is feeding by " + f.name);
                try
                {
                    Exceptions.ProcessFood(fargs.drink, fargs.foodAmount);
                    Exceptions.ProcessCatFood(fargs.foodAmount);
                    
                }
                catch (Exceptions ex)
                {
                    Console.WriteLine("It is incorrect amount of food for Cat or incorrect drink" + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Meow, I am not hungry");
            }
        }            
       public void Racion()
        {
            for (int i = 0; i < racion.FoodAmount; i++)
            {
                Console.WriteLine(racion.Meals[i]);
            }
        }

        public void toSleep()
        {
            Age++;
            isHungry = true;
        }

        public void makeSound()
        {
            Console.WriteLine("MEOOOOW");
        }
    }
}
