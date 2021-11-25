using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesNEvents
{
   public class MulticastDeligate
    {
        delegate void DelOp(int x, int y);
        public static void ImplementDeligate()
        {
            DelOp obj = Operation.Add;
            obj += Operation.Square;

            obj(5, 5);
            obj(8, 3);
            Console.ReadLine();

        }
        public class Operation // Creation of Operation Class
        {
            public static void Add(int a, int b)
            {
                Console.WriteLine("Addition = {0}", a + b);
            }
            public static void Square(int a, int b)
            {
                Console.WriteLine("Multiple = {0}", a * b);
            }
        }
    }
}
