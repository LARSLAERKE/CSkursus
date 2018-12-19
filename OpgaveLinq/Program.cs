using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            var r = new PersonNuGetPackage.PersonRepositoryRandom();
            var people = r.GetPeople(100);
            //foreach (var person in people)
            //    Console.WriteLine(person.Name);

            var p1 = r.Get10People();
            foreach (var person in p1)
            {
                Console.WriteLine($"{person.Gender} {person.Name} {person.Height} {person.IsHealthy}");
            }

            Console.WriteLine();

            var pSortNavn = p1
                .OrderBy(p => p.Gender)
                .ThenBy(p => p.Name)
                .Where(p => p.Height > 170 && p.IsHealthy);
            foreach (var person in pSortNavn)
            {
                Console.WriteLine($"{person.Gender} {person.Name} {person.Height} {person.IsHealthy}");
            }


            Console.WriteLine();
            var pGruppe = p1.GroupBy(p => p.Gender);
            foreach (var gr in pGruppe)
            {
                foreach (var person in gr)
                {
                    Console.WriteLine($"{person.Gender} {person.Name} {person.Height} {person.IsHealthy}");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            var pAA = p1.OrderBy(p => p.Name).Select(p => new { Name = p.Name, Height = p.Height });
            foreach (var person in pAA)
            {
                Console.WriteLine($"{person.Name} {person.Height}");

            }



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
