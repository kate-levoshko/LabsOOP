using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class FoodCollection<T> where T: IComparable, IEnumerable<T>, IEnumerator<T>, IDisposable
    {
        T[] meal;
        int pos = -1;
        private int foodAmount;

        public FoodCollection()
        {

        }

        public FoodCollection(T[] meal)
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


        public void Reset()
        {
            pos = -1;
        }


        public void Sort()
        {
            Array.Sort(this.meal);
            this.Reset();
        }


        public IEnumerator<T> GetEnumerator() { return (IEnumerator<T>)this; }

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


