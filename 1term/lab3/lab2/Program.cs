using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;

using System.Collections;

namespace lab1
{
    class Program
    {
        /* функция которая создает weak reference на Кота который не виден из других функций (например мейн) 
           иначе если создавать слабые ссылки на Кота в мейне то GC не удалит их так как обьект виден в блоке мейн, 
           даже если нет переменных, которые имеют этот обьект
         */

        public static WeakReference WR()
        {
            return new WeakReference(new Cat());
        }

        static void Main(string[] args)
        {
            Cat c1 = new Cat(true);
            Cat c2 = new Cat(true);
            Cat c3 = new Cat(true);
            Cat c4 = new Cat(true);

            Hamster h1 = new Hamster(true);
            Hamster h2 = new Hamster(true);
            /*
            Feeder feeder1 = new Feeder("Katya", 18, "Female");
            Feeder feeder2 = new Feeder("Stas", 19, "Male");

            Feeder[] feeders = new Feeder[5];

            feeders[0] = feeder1;
            feeders[1] = feeder2;

            //Animal[] animals = new lab1.Animal[] { c1, c2, h1, h2 };
            Cat[] cats = new Cat[] { c1, c2, c3, c4 };
            */

            /*
            Feeder feeder1 = new Feeder("Katya");
            Feeder feeder2 = new Feeder("Stas");
            BigZoo zoo1 = new BigZoo(feeder1);
            SmallZoo zoo2 = new SmallZoo(feeder2);
            feeder1.Feeding();
            feeder2.Feeding();
            */
            /*
            Animal[] animals = new lab1.Animal[] { c1, c2, h1, h2 };
            Console.WriteLine("\nRacion of cat: \n");
            c1.Racion();
            c1.SpecialRacion("milk");
            Console.WriteLine(animals.Length);
            */
            CatList<Cat> cList = new CatList<Cat>();

            cList.AddToWeakRefList(c1);
            cList.AddToWeakRefList(c2);
            cList.AddToWeakRefList(c3);
            cList.AddToWeakRefList(c4);
         

            GC.Collect();
            GC.WaitForPendingFinalizers();

            WeakReference wr = WR();
            Console.WriteLine("Is first object alive : " + wr.IsAlive.ToString()); 
                                                                                                                    
            GC.Collect(2, GCCollectionMode.Forced);

            Console.WriteLine("Is first object alive : " + wr.IsAlive.ToString());
           
            cList.Dispose();
            Console.WriteLine("List does not exist: " + (cList.wrList == null));// Ccылка  на список null 
            Console.WriteLine(cList.ToString());
            Console.ReadKey();
        }
    }

}

