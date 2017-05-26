using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            NewSite site = new NewSite();
            User katya = new User("Katya", "Levoshko", 18);
            User mother = new User("Larisa", "Levoshko", 50);
            User alina = new User("Alina", "Gritsai");
            site.enterTheSite(katya);
            site.enterTheSite(mother);
            site.enterTheSite(alina);
            Console.ReadKey();
        }
    }
}

