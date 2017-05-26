using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public abstract class Cleaning
    {
        public abstract void DoWork(HouseKeeper woman);
    }

    public class EasyCleaning : Cleaning
    {
        public override void DoWork(HouseKeeper woman)
        {
            Console.WriteLine("Fold things, sweep the floor");
        }
    }

    public class UsualCleaning : Cleaning
    {
        public override void DoWork(HouseKeeper woman)
        {
            Console.WriteLine("Wipe off dust, use a vacuum cleaner");
        }
    }

    public class GeneralCleaning : Cleaning
    {
        public override void DoWork(HouseKeeper woman)
        {
            Console.WriteLine("Wet cleaning, washing windows");
        }
    }

    public class HouseKeeper
    {
        protected int time;
        private Cleaning clean;

        public HouseKeeper(int time)
        {
            this.time = time;
        }

        public int Time
        {
            get { return time; }
            set { time = value;}
        }

        public Cleaning cleaning
        {
            get { return clean; }
            set
            {
                clean = value;
                Console.WriteLine("Cleaning: " + clean.GetType().Name);
            }
        }

        public void Request()
        {
            clean.DoWork(this);
        }

    }
}
