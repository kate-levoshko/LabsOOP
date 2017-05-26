using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Exceptions : Exception
    {
        private const string DRINK = "Water";

        public const int MAX_HAMSTER_FOOD_VALUE = 3;
        private const int MAX_CAT_FOOD_VALUE = 7;

        public Exceptions(string message) : base(message){ }

        public static void ProcessFood(string str, int amount)
        {
            if (amount < 0 || String.IsNullOrEmpty(str))
            {
                throw new ArgumentException();
            }
        }

        public static void ProcessHamsterFood(int amount)
        {
            if (amount > MAX_HAMSTER_FOOD_VALUE)
            {
                throw new ArgumentException();
            }
        }

        public static void ProcessCatFood(int amount)
        {
            if (amount > MAX_CAT_FOOD_VALUE)
            {
                throw new ArgumentException();
            }
        }

    }
}
