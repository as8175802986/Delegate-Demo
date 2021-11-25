using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesNEvents
{
    
    class Program
    {

        public static event DelEventHandler Add;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Delegates And Events program!!\n");
            Console.WriteLine("Events....{0}\n");
            Add += new DelEventHandler(Event.India);   // : Events.
            Add += new DelEventHandler(Event.Russia);
            Add += new DelEventHandler(Event.China);
            Add.Invoke();
            Console.ReadLine();
        }
    }
}
