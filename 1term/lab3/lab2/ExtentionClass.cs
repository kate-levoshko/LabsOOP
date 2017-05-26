using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public static class ExtensionClass
    {
        public static void Menu(this Food<string> menu)
        {
            for (int i = 0; i < menu.FoodAmount; i++)
            {
                Console.WriteLine(menu.Meals[i]);
            }
        }
    }
}
