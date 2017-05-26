using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    /* class Target */
    class Company
    {
        protected string name;
        protected int money;

        public Company() { }

        public Company(string name)
        {
            this.name = name;
        }

        public virtual void ExecuteContract(Customer cust)
        {
            if (cust.IsPay)
            {
                Console.WriteLine("Company executing contract with customer {0}", cust.Name);
            }
            else
            {
                Console.WriteLine("Company can`t execute contract with customer {0}", cust.Name);
            }
        }
    }

    /* class Adapter 
       Connect Company (Target) with Customer (Adaptee) */

    class AccountingDepartment : Company
    { 
        public AccountingDepartment() { }

        public override void ExecuteContract(Customer cust)
        {
            FormDocuments(cust);
            base.ExecuteContract(cust);
        }

        protected void FormDocuments(Customer cust)
        {
            if (cust.IsPay)
            {
                money++;
                Console.WriteLine("Documents for Customer {0} is formed", cust.Name);
            }
            else
            {
                Console.WriteLine("Customer {0} have not payed for item", cust.Name);
            }
        }
    } 

    /*Class Adaptee*/
    class Customer
    {
        protected string name;
        protected bool isPay;
        protected int money = 5;

        public Customer() { }

        public Customer(string name)
        {
            this.name = name;
        }

        public bool IsPay
        {
            set { isPay = value; }
            get { return isPay; }
        }

        public string Name
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Incorrect value of name");
                }
                else { name = value; }
            }
            get { return name; }
        }

        public void PayItem()
        {
            if (money > 0)
            {
                isPay = true;
                money--;
                Console.WriteLine("I am Customer {0}, I have payed your item", name);
            }
            else
            {
                Console.WriteLine("You can`t pay the Item, you don`t have money");
            }
           
        }
    }
}