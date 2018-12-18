using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveEgetInterface
{
    class Program
    {
        static void Main(string[] args)
        {


            List<IDbFunktioner> idbList = new List<IDbFunktioner>
            {
                new Hund(),
                new Ubåd(),
                new Hund(),
                new Hund(),
                new Ubåd(),
                new Ubåd(),
                new Hund(),
                new Hund(),
                new Ubåd()
            };

            foreach (var item in idbList)
            {
                item.Gem();
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
    class Hund:IDbFunktioner    
    {
        public string Navn { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer hund...");
        }
    }

    class Ubåd:IDbFunktioner
    {
        public int Nummer { get; set; }
        public double Tubine { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer ubåd...");
        }
    }

    interface IDbFunktioner
    {
        void Gem();

    }
}
