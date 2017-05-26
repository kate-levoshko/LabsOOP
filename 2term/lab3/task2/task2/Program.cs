using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Administration admin = new Administration(1000, 100);

            TypeFirm print_center = new PrintCenter();
            print_center.Price = 5.5;
            TypeFirm elite_company = new ElitePrintCompany();
            elite_company.Price = 8;

            if (admin.Money >= elite_company.Price*admin.AwardsAmount)
            {
                PaperProduction prod2 = new PaperProduction(elite_company);
                prod2.Run(elite_company);
            }
            else
            {
                PaperProduction prod1 = new PaperProduction(print_center);
                prod1.Run(print_center);

            }

            Console.ReadKey();
        }
    }
}


