using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveVariabler
{
    class Program
    {
        static void Main(string[] args)
        {
            int heltal = 10;
            double kommatal = 12.5;

            heltal++;
            heltal--;
            heltal += 20;
            Console.WriteLine($"Værdien af tallet er nu {heltal}.");

            kommatal++;
            kommatal--;
            kommatal *= 2;
            Console.WriteLine($"Værdien af tallet er nu {kommatal}.");



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
