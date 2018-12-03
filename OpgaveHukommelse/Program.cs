using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveHukommelse
{
    class Program
    {
        static void Main(string[] args)
        {

            Person k1 = new Person { Navn = "a" };
            Person k2 = new Person { Navn = "b" };
            Console.WriteLine(k1.Navn);
            Console.WriteLine(k2.Navn);

            k1 = k2;
            Console.WriteLine(k1.Navn);
            Console.WriteLine(k2.Navn);

            k1.Navn = "c";
            Console.WriteLine(k1.Navn);
            Console.WriteLine(k2.Navn);

            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        class Person
        {
            public string Navn;
        }

    }

}
