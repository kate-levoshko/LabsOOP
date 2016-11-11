using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Food<T>
    {
        T[] meal;
        private int foodAmount;

        public Food()
        {

        }

        public Food(T[] meal)
        {
            this.meal = meal;
            foodAmount = meal.Length;
        }

        public int FoodAmount
        {
            get { return foodAmount; }
        }

        public T[] Meals { get { return meal.ToArray(); } }

    }
}
