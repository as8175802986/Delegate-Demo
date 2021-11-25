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
            operation obj = new operation(SingleCast.Addition); // : Single Delegate.
            Console.WriteLine("Single Delegate!!...Addition is {0}\n", obj(55, 25));
            Console.WriteLine("MultiCast Delegates...\n");
            MulticastDeligate.ImplementDeligate();          // : MultiCast Delegate.
            Console.WriteLine("Events....{0}\n");
            Add += new DelEventHandler(Event.India);   // : Events.
            Add += new DelEventHandler(Event.Russia);
            Add += new DelEventHandler(Event.China);
            Add.Invoke();
            Console.ReadLine();
        }
    }
}
