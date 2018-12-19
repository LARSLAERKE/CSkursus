using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveDelegates
{
    class Program
    {

        //public delegate void MinDelegate1(string dtxt);

        static void Main(string[] args)
        {

            //MinDelegate1 f1 = new MinDelegate1(MinSkrivTilConsole);
            //f1.Invoke("Hello World!");

            //MinDelegate1 f2 = MinSkrivTilConsole;
            //f2("Hej verden");

            //MinDelegate1 f3 = MinSkrivTilConsole;
            //f3 += Console.WriteLine;
            //f3("Hallo Welt");

            //f1 -= MinSkrivTilConsole;
            //f2 -= MinSkrivTilConsole;
            //f3 -= MinSkrivTilConsole;
            //f3 -= Console.WriteLine;

            //if (f3 != null)
            //    f3("Er du der?");
            //else
            //    Console.WriteLine("f3 er der ikke!");



            Action<string> a1 = MinSkrivTilConsole;
            a1("Action a1");
            a1 += Console.WriteLine;

            if (a1 != null)
                a1("Hello World");
            else
                Console.WriteLine("a1 er der ikke!");

            a1?.Invoke("Ikke null");

            a1 -= MinSkrivTilConsole;
            a1 -= Console.WriteLine;

            a1?.Invoke("Ikke null");

            if (a1 != null)
                a1("Ikke null");
            else
                Console.WriteLine("a1 er der ikke!");








            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        static void MinSkrivTilConsole(string txt)
        {
            Console.WriteLine("**** " + txt + " ****");
        }

       
    }
}
