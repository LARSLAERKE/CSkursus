using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveEventFileWatcher
{
    class Program
    {
        static void Main(string[] args)
        {

            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;

            // bind en metode til w.Changed
            w.Changed += W_Changed;

            w.Created += (s, e) => Console.WriteLine("Oprettet " + e.FullPath); 

            do
            {

            } while (true);

        }

        private static void W_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("Fil ændret");
        }
    }
}
