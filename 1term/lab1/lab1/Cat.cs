using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Cat : Mammal
    {

        public Cat() : base()
        {
        }

        public Cat(String name, int age, bool isHunter) : base(name, age, isHunter)
        {
        }

        protected override void Action()
        {
            Console.WriteLine("MEOOOOOW, I am hungry");
        }

        protected override void eatMammal()
        {
            Console.WriteLine("I am eating Mammals, because I am a hunter");
        }

    }
}
