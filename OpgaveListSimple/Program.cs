using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveListSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persLst = new List<Person>();
            persLst.Add(new Person(12, "Lars"));
            persLst.Add(new Person(34, "Carina"));
            persLst.Add(new Person(8, "Otto"));

            Console.WriteLine($"Id: {persLst[2].Id}  Navn: {persLst[2].Navn}");



            foreach (Person item in persLst)
            {
                Console.WriteLine($"Id: {item.Id}  Navn: {item.Navn}");
            }

            int i = 1;
                        
            Dictionary<int,Person> persDict = new Dictionary<int, Person>();
            persDict.Add(i,new Person(12, "Lars"));
            i++;
            persDict.Add(i,new Person(34, "Carina"));
            i++;
            persDict.Add(i,new Person(8, "Otto"));

            Console.WriteLine($"Id: {persDict[3].Id}  Navn: {persDict[3].Navn}");


            foreach (var item in persDict)
            {
                Console.WriteLine($"Id: {item.Value.Id}  Navn: {item.Value.Navn}");
            }



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
    class Person
    {
        public Person(int id,string navn)
        {
            this.Id = id;
            this.Navn = navn;
        }
        public int Id { get; set; }
        public string Navn { get; set; }
    }
}

