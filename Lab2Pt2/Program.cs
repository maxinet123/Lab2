using System;

namespace Lab2Pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Manager mgr = new Manager();
            Client client = new Client(mgr);
            client.work();
        }
    }
}
