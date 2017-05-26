using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            Composite director = new Composite("Dychka");
            director.Isknow = true;
            Composite zam1 = new Composite("Temnikova");
            Composite zam2 = new Composite("Tarasenko");

            director.Add(zam1);
            director.sayAboutOrder(zam1);
            director.Add(zam2);
            director.sayAboutOrder(zam2);

            Composite depart_chief1 = new Composite("Sushchuk");
            Composite depart_chief2 = new Composite("Sapsai");
            Composite depart_chief3 = new Composite("Chertov");

            zam1.Add(depart_chief1);
            zam2.Add(depart_chief2);
            zam2.Add(depart_chief3);

            zam1.sayAboutOrder(depart_chief1);
            zam1.sayAboutOrder(depart_chief2);

            SimpleWorker teacher1 = new SimpleWorker("Hadyniak");
            SimpleWorker teacher2 = new SimpleWorker("Vovk");
            SimpleWorker teacher3 = new SimpleWorker("Syrik");
            SimpleWorker teacher4 = new SimpleWorker("Marchenko");
            SimpleWorker teacher5 = new SimpleWorker("Bohonov");



            depart_chief1.Add(teacher1);
            depart_chief2.Add(teacher2);
            depart_chief3.Add(teacher3);
            depart_chief3.Add(teacher4);
            depart_chief3.Add(teacher5);

            director.GetKnowledgeInfo();
            director.Display(2);
          
            Console.ReadKey();

        }
    }
}
