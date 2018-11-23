using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConOpgaveDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            DateTime d2 = DateTime.Now;
            DateTime d3 = DateTime.Now;
            TimeSpan t1;
            TimeSpan t2 = new TimeSpan(16,0,0);
            TimeSpan t3 = new TimeSpan(0,30,00);
            TimeSpan t4;
            TimeSpan t5;

            d1 = d1.AddDays(10);
            Console.WriteLine($"Tid om 10 dage = {d1}.");

            d1 = d1.AddMinutes(20);
            Console.WriteLine($"Tid om 10 dage og 20 minutter = {d1}.");

            d1 = d1.AddMonths(-1);
            Console.WriteLine($"En måned tidligere = {d1}.");

            d2 = d1;
            t1 = d3-d2;
            Console.WriteLine($"Tid mellem d2 og d3 = {t1}.");

            Console.WriteLine($"T2 = {t2}.");
            Console.WriteLine($"T3 = {t3}.");
            t4 = t2 - t3;
            Console.WriteLine($"T4 = {t4}.");
            t5 = t2 + t3;
            Console.WriteLine($"T5 = {t5}.");





            DateTime rundate = new DateTime(2018,1,5);
            DateTime eomdate = getEom(rundate);
            eomdate = getEomPrevMnt(rundate);
            Console.WriteLine(eomdate);
            Console.WriteLine(eomdate.DayOfWeek);


            DateTime getEom(DateTime startOfMonth)
            {                
                startOfMonth = new DateTime(startOfMonth.Year, startOfMonth.Month, 1);
                startOfMonth = startOfMonth.AddMonths(1);

                switch (startOfMonth.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        return (startOfMonth.AddDays(-3));
                    case DayOfWeek.Sunday:
                        return (startOfMonth.AddDays(-2));
                    default:
                        return (startOfMonth.AddDays(-1));
                }
            }

            DateTime getEomPrevMnt(DateTime startOfMonth)
            {
                startOfMonth = new DateTime(startOfMonth.Year, startOfMonth.Month, 1);

                switch (startOfMonth.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        return (startOfMonth.AddDays(-3));
                    case DayOfWeek.Sunday:
                        return (startOfMonth.AddDays(-2));
                    default:
                        return (startOfMonth.AddDays(-1));
                }
            }



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
