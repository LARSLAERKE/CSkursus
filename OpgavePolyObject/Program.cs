using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgavePolyObject
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2018, 12, 18);
            Faktura f1 = new Faktura(12,d1,"Lars");

            Console.WriteLine(f1.ToString());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

    }

    class Faktura
    {
        //Constructor
        public Faktura(int nr, DateTime dato, string kunde)
        {
            this.Nr = nr;
            this.Dato = dato;
            this.Kunde = kunde;
        }

        //Properties
        public int Nr { get; set; }
        public DateTime Dato { get; set; }
        public string Kunde { get; set; }


        //Methods
        public override string ToString()
        {
            return $"Faktura til {this.Kunde} nr {this.Nr} fra {this.Dato}";
        }

    }
}
