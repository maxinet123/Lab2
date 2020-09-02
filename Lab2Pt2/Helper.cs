using Lab2Pt2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Pt2
{
    public class Helper
    {
        private RemoveMethod remove;

        public Helper(RemoveMethod done)
        {
            remove = done;
        }
        public void doWork()
        {
            Console.WriteLine("Executes a task");
        }

        public void finished()
        {
            Console.WriteLine("Helper completes task");
        }
    }
}
