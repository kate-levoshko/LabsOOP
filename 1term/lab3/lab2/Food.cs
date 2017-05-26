using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Food<T> where T : IComparable
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

        private int GetFood(T testFood)
        {
            for (int j = 0; j < foodAmount; j++)
            {
                if (meal[j].CompareTo(testFood) == 0)
                {
                    Console.WriteLine("In menu this meal has a number: " + (j + 1));
                }
            }
            return 0;
        }

        public T[] Meals { get { return meal.ToArray(); } }

        public int this[T food]
        {
            get
            {
                return (GetFood(food));
            }
        }
    }
}
