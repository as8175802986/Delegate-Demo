using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesNEvents
{
    public delegate int operation(int x, int y);
    class SingleCast
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }
    }
}
