using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveClassSimple
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.Alder());

            Person p2 = new Person("Lars","Lærke",1971);
            Console.WriteLine(p2.FuldtNavn());
            Console.WriteLine(p2.Alder());

            
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }


    }

    public class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;


        public Person()
        {
            this.Fornavn = "";
            this.Efternavn = "";
        }
        public Person(string fornavn, string efternavn, int fødselsår)
        {
            this.Fornavn = fornavn;
            this.Efternavn = efternavn;
            this.Fødselsår = fødselsår;
        }

        public string FuldtNavn() => this.Fornavn + " " + this.Efternavn;

        public int Alder() => DateTime.Now.Year - this.Fødselsår;


    }

}
