using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Mammal : Animal
    {
        private bool isHunter;

        public Mammal() : base()
        {
        }
        /*
         * Add new param for this class
         */
        public Mammal(String name, int age, bool isHunter) : base(name, age) 
        {
            this.isHunter = isHunter;
        }

        public void mammalRacion()
        {
            if (isHunter)
            {
                eatMammal();
            }
            else
            {
                Console.WriteLine("I eat vegetables and fruits, because it isn`t hunter");
            }
        }

            virtual protected void eatMammal()
        {
            Console.WriteLine("I am eating Mammals, because I am a hunter");
        }
    }
}
