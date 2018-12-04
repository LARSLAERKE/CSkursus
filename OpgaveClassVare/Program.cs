using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveClassVare
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare v = new Vare();
            v.Navn = "vare #1";
            v.Pris = 100;
            Console.WriteLine(v.PrisMedMoms());
            Vare v2 = new Vare("vare #2", 200);
            var i = v2.Navn;
            var j = v2.Pris;
            Console.WriteLine(v2.PrisMedMoms());

            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    class Vare
    {
        // Fields
        private string navn;
        private double pris;

        // Constructors
        public Vare()
        {

        }

        public Vare(string navn, double pris)
        {
            this.navn = navn;
            this.pris = pris;
        }

        // Properties
        public string Navn
        {
            get
            {
                Console.WriteLine($"Navnet er: {this.navn}");
                return this.navn;
            }
            set
            {
                Console.WriteLine($"Nyt navn er: {value}");
                this.navn = value;
            }
        }

        public double Pris
        {
            get
            {
                Console.WriteLine($"Prisen på {this.navn} er: {this.pris}");
                return this.pris;
            }
            set
            {
                Console.WriteLine($"Ny pris tildeles {this.navn}: {value}");
                this.pris = value;
            }
        }

        // Methods
        public double PrisMedMoms()
        {
            return this.pris * 1.25;
        }

    }
}
