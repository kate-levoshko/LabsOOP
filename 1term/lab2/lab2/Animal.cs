/*
 * Lab 2 for OOP Course in KPI
 * Author: Katerina Levoshko
 * Date 11/5/2016
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
    abstract class Animal
    {
        private const int MAX_ANIMAL_AGE = 300;

        private string name;
        private int age;

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

        abstract public void Feed(Feeder f, FoodEventArgs fargs);
 
    }
}
