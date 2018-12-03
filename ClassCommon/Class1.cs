using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCommon
{
    public class Terning
    {
        private int værdi;
        private bool snyd;

        private static Random rnd = new Random();

        public Terning()
        {
            this.Ryst();
            this.snyd = false;
        }
        public Terning(bool snyd)
        {
            this.værdi = 1;
            this.snyd = snyd;
        }

        public void Ryst() => this.værdi = this.snyd ? 6 : rnd.Next(1, 7);

        public void Skriv() => Console.WriteLine($"[{this.værdi}]");
    }
}
