using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            FilTyper ft = FilTyper.Csv;
            Console.WriteLine(ft);
            Console.WriteLine((int)ft);

            Person p = new Person(1, "Mikkel", Køn.Mand);
            Console.WriteLine(p.Navn);
            Console.WriteLine(p.Køn);

            

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    public enum FilTyper
    {
        Pdf,
        Txt,
        Csv
    }
}
