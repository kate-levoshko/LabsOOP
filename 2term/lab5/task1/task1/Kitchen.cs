using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{

    public abstract class AbstractCook
    {
        protected AbstractCook Successor { get; set; }
        public abstract void Handle(Order order);
    }

    public class MeatCook : AbstractCook
    {
        public override void Handle(Order order)
        {
            if (order.MeatCook)
                Console.WriteLine("Cooking meat");
            if (Successor != null)
                Successor.Handle(order);
        }
    }


    public class SideDishCook : AbstractCook
    {
        public override void Handle(Order order)
        {
            if (order.SideDishCook)
                Console.WriteLine("Cooking side dish");
            if (Successor != null)
                Successor.Handle(order);
        }
    }

    public class SaladCook : AbstractCook
    {
        public override void Handle(Order order)
        {
            if (order.SaladCook)
                Console.WriteLine("Cooking salad");
            if (Successor == null)
                Console.WriteLine("The order is ready");
        }
    }

    public class Order
    {
        public bool MeatCook { get; set; }
        public bool SaladCook { get; set; }
        public bool SideDishCook { get; set; }

        public Order(bool meatCook, bool saladCook, bool sideDishCook)
        {
            MeatCook = meatCook;
            SaladCook = saladCook;
            SideDishCook = sideDishCook;
        }
    }
}