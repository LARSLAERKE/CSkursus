using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgavePolyDyr
{
    class Program
    {
        static void Main(string[] args)
        {

            Hund h1 = new Hund() { Navn = "Cato" };
            h1.SigNoget();

            Hund h = new Hund() { Navn = "a" };
            h.SigNoget();

            Kat k = new Kat() { Navn = "b" };
            k.SigNoget();

            Dyr d = new Kat() { Navn = "c" };
            d.SigNoget();


            List<Dyr> forskelligeDyr = new List<Dyr>() { h, k, new Hund() { Navn = "c" }, new Kat() { Navn = "d" } };
            foreach (Dyr item in forskelligeDyr)
            {
                item.SigNoget();
            }
            Console.WriteLine();


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }


    abstract class Dyr
    {
        //Properties
        public string Navn { get; set; }

        //Methods
        public virtual void SigNoget()
        {
            Console.WriteLine($"Jeg er et dyr og hedder {this.Navn}");
        }
    }

    class Hund : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine($"Jeg er en hund og hedder {this.Navn}");
        }
    }

    class Kat : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine($"Jeg er en kat og hedder {this.Navn}");
        }
    }


}
