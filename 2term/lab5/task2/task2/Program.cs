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
            Computer computer = new Computer();
            ICommand command = new LoginCommand(computer);
            Client user1 = new Client();
            Client user2 = new Client();

            user1.SetCommand(command);
            user1.Login(user2);
        }
    }
}
