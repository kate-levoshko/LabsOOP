using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Bird : Animal
    {
        /*
         * We can`t create empty copy of Bird, because of private constructor  
         */
        public Bird() : base() 
        {
        }

        public Bird(String name, int age) : base(name, age)
        {
        }

        protected override void Action()
        {
            Console.WriteLine("Singing of bird");
        }
    }
}
