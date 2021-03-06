﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Client
    {
        private Manager mgr = new Manager();
        public Client(Manager manager)
        {
            mgr = manager;
        }

        public void work()
        {
            Console.WriteLine("Client requests help to manager");
            Helper h = mgr.requestHelp();
            h.doWork();
            h.finished();
            Console.WriteLine("Client is happy after was completed");
        }
    }
}
