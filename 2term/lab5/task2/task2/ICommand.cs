﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public interface ICommand
    {
        void Execute();
        void SendCommand(ICommand command, Client client);
    }
}