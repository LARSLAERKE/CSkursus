using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveAutoProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Fornavn = "Lars";
            p.Efternavn = "Lærke";

            Console.WriteLine(p.FuldtNavnMetode());


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    class Person
    {
        public string Fornavn { get; set; }
        private string efternavn;

        private string fuldtNavn;

        public string FuldtNavn
        {
            get { return $"{this.Fornavn} {this.Efternavn}"; }
            set { this.fuldtNavn = value; }
        }



        public string Efternavn
        {
            get { return this.efternavn; }
            set
            {
                if (value.Length < 3) 
                {
                    this.efternavn = "";
                }
                else
                {
                    this.efternavn = value;
                }
            }
        }

        public string FuldtNavnMetode()
        {
            return $"{this.Fornavn} {this.Efternavn}";
        }

    }



}
