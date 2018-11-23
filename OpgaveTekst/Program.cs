using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveTekst
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Mikkel";
            Console.WriteLine(fornavn);
            string efternavn = "Cronberg";
            Console.WriteLine(efternavn);
            string samletNavn = $"{fornavn} {efternavn}";
            Console.WriteLine(samletNavn);
            string navnStort = samletNavn.ToUpper();
            Console.WriteLine(navnStort);
            string navnLille = samletNavn.ToLower();
            Console.WriteLine(navnLille);
            string navnDel = samletNavn.Substring(7, 4);
            Console.WriteLine(navnDel);

            string navnDel2 = samletNavn.Substring(samletNavn.IndexOf(' ')+1,4);
            Console.WriteLine(navnDel2);

            Console.WriteLine("\n");

            string textForFile = $"{samletNavn}\r\n{navnStort}\r\n{navnLille}\r\n{navnDel2}";
            
            Console.WriteLine(textForFile);


            System.IO.File.WriteAllText("C:\\source\\OpgaveTekst.txt", textForFile);

 




            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
