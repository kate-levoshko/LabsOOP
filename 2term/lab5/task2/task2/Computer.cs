using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Computer
    {
        private string _login = "user1";
        private string _password = "123456";

        public void EnterData()
        {
            Console.WriteLine("\n\nEnter Login and Password");
            Console.WriteLine("Login:");
            string login = Console.ReadLine();
            Console.WriteLine("Password:");
            string pass = Console.ReadLine();
            if (login == _login && pass == _password)
                Console.WriteLine("Enter user with login: {0}", _login);
            else
                Console.WriteLine("Incorrect login or password");
        }
    }

    public class Client
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void Login(Client client = null)
        {
            _command.Execute();
            if (client != null)
                _command.SendCommand(_command, client);
            else
                Console.WriteLine("Nobody send the command");
        }
    }

    public class LoginCommand : ICommand
    {
        private Computer _computer;

        public LoginCommand(Computer computer)
        {
            _computer = computer;
        }

        public void SendCommand(ICommand command, Client client = null)
        {
            if (client != null)
            {
                client.SetCommand(command);
                client.Login();
            }
        }

        public void Execute()
        {
            _computer.EnterData();
        }
    }
}
