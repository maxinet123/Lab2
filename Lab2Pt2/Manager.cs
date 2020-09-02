using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Pt2
{
    public class Manager : RemoveMethod
    {
        private List<Helper> active = new List<Helper>();

        public void remove(Helper h)
        {
            active.Remove(h);
            h.finished();
        }

        public Helper requestHelp()
        {
            Helper h = new Helper(this);
            active.Add(h);
            Console.WriteLine("Manager assigns a helper to client");
            return h;
        }
    }
}
