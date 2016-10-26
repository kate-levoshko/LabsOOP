using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Hamster : Mammal
    {
        public Hamster() : base()
        {
        }

        public Hamster (String name, int age, bool isHunter) : base (name, age, isHunter)
        {
        }

        protected override void Action()
        {
            Console.WriteLine("Fifyut-fifyut, I am hungry");
        }

        protected override void eatMammal()
        {
            Console.WriteLine("I eat vegetables and fruits, because it isn`t hunter");
        }

    }
}
