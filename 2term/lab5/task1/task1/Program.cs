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
            Order order = new Order(true, false, true);
            AbstractCook meat = new MeatCook();
            AbstractCook salad = new SaladCook();
            AbstractCook sideDish = new SideDishCook();
            meat.Successor = sideDish;
            sideDish.Successor = salad;

            meat.Handle(order);

            Console.ReadKey();
        }
    }
}
