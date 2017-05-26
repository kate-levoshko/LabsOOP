using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Administration
    {
        protected double money;
        protected int awards_amount;

        public Administration(double budjet, int amount)
        {
            this.money = budjet;
            this.awards_amount = amount;
        }
        public double Money
        {
            get { return money; }
        }

        public int AwardsAmount
        {
            get { return awards_amount; }
        }
    }
}



