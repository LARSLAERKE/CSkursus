using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveArvTerning
{
    class Program
    {
        static void Main(string[] args)
        {
            //Terning t = new Terning();
            //t.Skriv();
            //t.Ryst();
            //t.Skriv();

            LudoTerning l = new LudoTerning();
            l.Skriv();
            //for (int i = 0; i < 10; i++)
            //{
            //    l.Skriv();
            //    Console.WriteLine(l.ErGlobus());
            //    Console.WriteLine(l.ErStjerne());
            //    l.Ryst();
            //}

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    public class Terning
    {
        //Fields
        private int værdi;

        //Constructors
        public Terning() => this.Ryst();
        public Terning(int _værdi) => this.Værdi = _værdi;
        static Terning() => rnd = new Random(); // Only executed once (first init of class)

        //Properties
        public int Værdi
        {
            get => this.værdi;
            set => this.værdi = ( value >= 1 && value <= 6 ) ? value : 1;
        }

        //Methods
        public void Ryst() => this.Værdi = rnd.Next(1, 7);
        public virtual void Skriv() => Console.WriteLine($"[{this.værdi}]");

        //Classes
        private static Random rnd;
    }

    public class LudoTerning : Terning
    {
        //Constructors
        public LudoTerning() : base() { }
                
        public LudoTerning(int _værdi) : base(_værdi) { }

        //Methods
        public bool ErGlobus() => this.Værdi == 3;
        public bool ErStjerne() => this.Værdi == 5;

        public override void Skriv()
        {
            if (this.ErGlobus())
                Console.WriteLine("[G]");
            else
                if (this.ErStjerne())
                    Console.WriteLine("[S]");
                else
                    base.Skriv();
        }
    }

    public class TerningBæger
    {



        //Metoder? FuldtHus,  


    }


}
