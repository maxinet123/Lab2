using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Helper
    {
        private Manager myManager;
        public Helper(Manager myManager)
        {
            this.myManager = myManager;
        }
        public void doWork()
        {
            Console.WriteLine("Executes a task");
        }

        public void finished()
        {
            myManager.remove(this);
            Console.WriteLine("Helper completes task");
        }
    }
}
