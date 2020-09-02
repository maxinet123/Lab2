using System;

namespace Lab2Pt2
{
    public delegate void RemoveMethod(Helper h);
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
