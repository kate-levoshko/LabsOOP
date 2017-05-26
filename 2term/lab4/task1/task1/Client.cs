using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public abstract class Client
    {
        protected string name;
        protected double money;
        protected double client_duration;
        protected double last_buying;

        public Client() { }

        public Client (string c_name, double c_money, double c_duration, double c_lastbuying)
        {
            this.name = c_name;
            this.money = c_money;
            this.client_duration = c_duration;
            this.last_buying = c_lastbuying;

        }

        public Client(string c_name, double c_money)
        {
            this.name = c_name;
            this.money = c_money;
        }

        public Client Status
        {
            set { Status = value; }
        }

        public abstract double countSale(double price);
    }

    public class SimpleClient : Client
    {
        public SimpleClient() : base() { }
        public SimpleClient(string name, double money, double duration, double lastbuying)
                            : base(name, money, duration, lastbuying)
        {
            this.name = name;
            this.money = money;
            if (duration < 0.5)
            {
                this.client_duration = duration;
            }
            this.last_buying = lastbuying;
        }

        public override double countSale(double price)
        {
            return price;
        }
    }

    public class ConstantClient : Client
     {
         public ConstantClient() : base() { }
         public ConstantClient(string name, double money, double duration, double lastbuying) 
                              : base(name, money,  duration, lastbuying)
        {
             this.name = name;
             this.money = money;
            if (duration > 0.5)
            {
                this.client_duration = duration;
            }
            this.last_buying = lastbuying;
        }

         public override double countSale(double price)
         {
             return 0.95*price;
         }
     }

        public class VIP_Client : Client
        {
            public VIP_Client() : base() { }
            public VIP_Client(string name, double money, double duration, double lastbuying) 
                            : base(name, money,  duration, lastbuying)
        {
                this.name = name;
                this.money = money;
            if (duration > 0.5 && lastbuying == 1)
            {
                this.client_duration = duration;
                this.last_buying = lastbuying;
            }
       }
            
            public override double countSale(double price)
            {
                return 0.85*price;
            }
        }

    public class Abonement
    {
        private Client client;
        protected double price;

        public Abonement(Client client, double price)
        {
            this.client = client;
            this.price = price;
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Client Status
        {
            set { client = value; }
        }

        public void countSale()
        {
            Console.WriteLine("The price of this abonement: "+client.countSale(price));
        }
    }
}

   