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
            EasyCleaning easyClean = new EasyCleaning();
            UsualCleaning usualClean = new UsualCleaning();
            GeneralCleaning generalClean = new GeneralCleaning();

            HouseKeeper hk = new HouseKeeper(2);
            if (hk.Time < 1)
            {
                hk.cleaning = easyClean;
            }
            else if (hk.Time > 6)
            {
                hk.cleaning = generalClean;
            }
            else
            {
                hk.cleaning = usualClean;
            }

            hk.Request();
            Console.ReadKey();
        }
    }
}
