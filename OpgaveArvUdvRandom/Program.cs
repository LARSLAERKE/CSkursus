using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveArvUdvRandom
{
    class Program
    {
        static void Main(string[] args)
        {

            UdvidetRandom r = new UdvidetRandom();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(r.NextBool());
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
    class UdvidetRandom : Random
    {
        public bool NextBool() => this.Next(1, 1001) <= 500;
    }
}

