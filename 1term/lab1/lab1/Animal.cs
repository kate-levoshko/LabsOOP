/*
 * Lab 1 for OOP Course in KPI
 * Author Katerina Levoshko
 * Date 10/8/2016
 * 
 * Description: Show principles of OOP on Animals hierarchy
 * Detailed information you can see on Class Diagram
 * 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Animal
    {
        private const int MAX_ANIMAL_AGE = 300;

        private string name;
        private int age;
        private bool isHungry;

        private static int animalCounter;

        public string Name
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Incorrect value of name");
                }
                else { name = value; }
            }
            get { return name; }
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

        static Animal()
        {
            animalCounter = 0;
        }

        public Animal()
        {
            name = "Animal#" + animalCounter; //default name of every Animal
            age = 0;
            animalCounter++;
        }

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
            animalCounter++;
        }

        public void animalAmount()
        {
            Console.WriteLine("{0} 'Animal' objects is created", animalCounter);
        }

        public void toFeed()
        {
            if (!isHungry)
            {
                Console.WriteLine("You can`t feed it. Animal is not hungry");
            }
            else
            {
                isHungry = false;
                Console.WriteLine("Animal is eating");
            }
        }

        public void toSleep()
        {
            Console.WriteLine("Animal is sleeping");
            isHungry = true;
        }
        
        public void makeSound()
        {
            if (isHungry)
            {
                Action();
            }
            else
            {
                Console.WriteLine("Animal doesn`t make a sound, because it isn`t hungry");
            }
        }

        virtual protected void Action()
        {
            Console.WriteLine("Animal sounding");
        }
        /*
         * Overriding "ToString"
         * */
        public override string ToString()
        {
            return "This is " + GetType().Name + ". " + "It name " + name + " and age " + age + ".";
        }

    }
}
