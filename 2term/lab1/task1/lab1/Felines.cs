using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public abstract class Felines
    {
        protected const int MAX_ANIMAL_AGE = 300;
        protected const int MIN_WEIGHT = 30;

        protected double weight;
        protected double growth;
        protected int age;
        protected string areal;
        protected string race;
        protected string name;

        public abstract void toEat();
        public abstract void toSleep();
        public abstract void ShowInfo();
    }

    public class BigPredators : Felines
    {

        public BigPredators(double weight, double growth, int age, string areal, string race)
        {
            this.weight = weight;
            this.growth = growth;
            this.age = age;
            this.areal = areal;
            this.race = race;
        }

        public string Areal
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Incorrect value of areal");
                }
                else { areal = value; }
            }
            get { return areal; }
        }

        public int Age
        {
            set
            {
                if (age > 0 || age < MAX_ANIMAL_AGE)
                {
                    age = value;

                }
                else
                {
                    Console.WriteLine("Incorrect age");
                }
            }
            get { return age; }
        }


        public override void toEat()
        {
            if (weight > 80)
            {
                Console.WriteLine("Weight is too big, you should not eat");
            }
            else
            {
                weight += 0.5;
            }
        }
        public override void toSleep()
        {
            if (weight < MIN_WEIGHT && age > 2)
            {
                Console.WriteLine("Weight is too small, you should eat");
            }
            else
            {
                weight -= 0.5;
            }
            if (age < 3) growth += 0.03;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("I am Big Predator. My weight is {0}. My growth is {1}. My age is {2}. My race is {3}. My areal is {4}.", weight, growth, age, race, areal);
        }
    }

   public abstract class Decorator : Felines
    {
        Felines animal;

        public void connect(Felines baseanimal)
        {
            this.animal = baseanimal;
        }

        public override void toEat()
        {
            if (animal != null) animal.toEat();
        }
        public override void toSleep()
        {
            if (animal != null) animal.toSleep();
        }
        public override void ShowInfo()
        {
            if (animal != null) animal.ShowInfo();
        }
    }

    public class Lion : Decorator
    {
        public override void toEat()
        {
            Console.Write("I want to eat meat");
            base.toEat();
        }

        public override void toSleep()
        {
            Console.Write("I want to sleep");
            base.toSleep();
        }

        public override void ShowInfo()
        {
            Console.WriteLine("I am Lion");
            base.ShowInfo();
        }

        public void hunting()
        {
            Console.WriteLine("I am lion, I want hunting");
            weight -= 0.2;
        }

    }


    public class HomeAnimals : Felines
    {
        protected string name;

        public HomeAnimals(string name, double weight, double growth, int age, string areal, string race)
        {
            this.name = name;
            this.weight = weight;
            this.growth = growth;
            this.age = age;
            this.areal = areal;
            this.race = race;
        }

        public string Name
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Incorrect value of areal");
                }
                else { name = value; }
            }
            get { return name; }
        }

        public override void toEat()
        {
            if (weight > 50)
            {
                Console.WriteLine("Weight is too big, you should not eat");
            }
            else
            {
                weight += 0.1;
            }
        }
        public override void toSleep()
        {
            if (weight < MIN_WEIGHT && age > 2)
            {
                Console.WriteLine("Weight is too small, you should eat");
            }
            else
            {
                weight -= 0.2;
            }
            if (age < 3) growth += 0.01;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("I am home animal. My name is {0}. My weight is {1}. My growth is {2}. My age is {3}. My race is {4}. My areal is {5}", name, weight, growth, age, race, areal);
        }
    }

    public class Cat : Decorator
    {
        public override void toEat()
        {
            Console.Write("I want to eat Wiskas");
            base.toEat();
        }

        public override void toSleep()
        {
            Console.Write("I want to sleep");
            base.toSleep();
        }

        public override void ShowInfo()
        {
            Console.WriteLine("I am Cat");
            base.ShowInfo();
        }

        public void playWithSun()
        {
            Console.WriteLine("I am playing with sun hare");
        }
    }
 }

