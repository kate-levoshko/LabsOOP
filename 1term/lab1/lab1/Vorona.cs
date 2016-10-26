using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Vorona : Bird 
    {
        private string region;

        private Vorona(String name, int age, String region) : base(name, age)
        {
            this.region = region;
        }

        public static void createVorona(String name, int age, String region)
        {
            if (String.Equals(region, "Australia"))
            {
                Console.WriteLine("We can`t create Vorona in this region");
            }
            else
            {
                Vorona v = new Vorona(name, age, region);
            }
        }

        protected override void Action()
        {
            Console.WriteLine("I am very popular");
        }

    }
}
