using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveLambda
{
    class Program
    {
        static void Main(string[] args)
        {

            System.IO.FileSystemWatcher fs =
                new System.IO.FileSystemWatcher(@"c:\temp");

            fs.EnableRaisingEvents = true;
            fs.Created += (s, e) => {
                Console.WriteLine("oprettet " + e.Name);
            };

            fs.Deleted += (s, e) => {
                Console.WriteLine("delete " + e.Name);
            };

            List<int> a = new List<int>() { 5, 1, 51, 7, 1, 56, 36, 5 };

            Console.WriteLine(a.FindIndex(Find));
            Console.WriteLine(a.FindIndex(i => i == 7));

            a.ForEach(skriv);

            a.ForEach(i => Console.WriteLine(i));

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        static void skriv(int a)
        {
            Console.WriteLine(a);
        }


        static bool Find(int i)
        {
            return i == 51;
        }
    }
}
