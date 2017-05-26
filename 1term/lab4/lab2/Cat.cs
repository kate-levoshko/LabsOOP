using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab1
{
    [Serializable]
    public class Cat : Animal, IAction, IComparable, IDisposable// IRacion
    {
        public bool isHungry;
        public string name;
        Food<String> racion = new Food<String>(new String[]{ "meat", "milk", "fish"});
        enum RACION { meat, milk, bread, fish };

        public Cat()
        {

        }
        public Cat(string name, bool isHungry)
        {
            this.name = name;
            this.isHungry = isHungry;
        }

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
            Console.WriteLine(RACION.bread);
            Console.WriteLine(RACION.fish);
            Console.WriteLine(RACION.meat);
            Console.WriteLine(RACION.milk);
        }

        public void SpecialRacion(string arg)
        {
            Console.WriteLine(racion[arg]);
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

        int IComparable.CompareTo(object obj)
        {
            if (!(obj is Cat))
                throw new ArgumentException();

            Cat cat = (Cat)obj;

            if (this.Age > cat.Age) return 1;
            if (this.Age < cat.Age) return -1;
            else return 0;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
