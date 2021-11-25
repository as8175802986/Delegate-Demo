using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesNEvents
{
    public delegate void DelEventHandler();
    class Event
    {
        public static void India()
        {
            Console.WriteLine("India\n");
        }
        public static void Russia()
        {
            Console.WriteLine("Russia\n");
        }
        public static void China()
        {
            Console.WriteLine("China\n");
        }
    }
}
