using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Manager mgr = new Manager();
            Client client = new Client(mgr);
            client.work();
        }
    }
}
