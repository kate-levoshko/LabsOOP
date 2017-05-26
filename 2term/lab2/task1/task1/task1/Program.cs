using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            Customer cust = new Customer("Katya");
            Customer cust2 = new Customer("Polina");
            AccountingDepartment dep = new AccountingDepartment();
            cust.PayItem();
            dep.ExecuteContract(cust);
            dep.ExecuteContract(cust2);
            Console.ReadKey();
        }
    }
}