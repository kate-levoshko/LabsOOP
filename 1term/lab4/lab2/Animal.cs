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
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace lab1
{
 
   public abstract class Animal
    {
        private const int MAX_ANIMAL_AGE = 300;

        public string name;
        
        public int age;

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

        public Animal()
        {
           
        }

        static Animal()
        {
            animalCounter = 0;
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
