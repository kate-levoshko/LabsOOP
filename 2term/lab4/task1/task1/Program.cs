using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Client simple = new SimpleClient("Katya", 1000, 0.3, 1);
            Client constant = new ConstantClient("Natasha", 1000, 0.6, 1);
            Client vip = new VIP_Client("Natasha", 1000, 1.0, 1);

            Abonement abon = new Abonement(simple, 150.9);
            abon.countSale();

            abon.Status = constant;
            abon.countSale();

            abon.Status = vip;
            abon.countSale();

            Console.ReadKey();

        }
    }
}

