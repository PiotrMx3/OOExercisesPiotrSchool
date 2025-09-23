using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
    internal class ClassesAndObjects
    {
        public static void ShowSubmenu()
        {

            Console.WriteLine("Uit te voeren oefening?");
            Console.WriteLine("1: DemoCombinationOf2Numbers ");
            //Console.WriteLine("2: H10-Birthday");
            //Console.WriteLine("3: H10-DayOfTheWeek");
            //Console.WriteLine("4: H10-TicksSince2000");
            //Console.WriteLine("5: H10-LeapYearCount");
            //Console.WriteLine("6: H10-CodeTiming");

            string k = Console.ReadLine() ?? "".Trim();

            switch (k)
            {
                case "1":
                    DemoCombinationOf2Numbers();
                    break;
                default:
                    Console.WriteLine("Verkeerd keuze !");
                    break;
            }




        }
            private static void DemoCombinationOf2Numbers()
            {
                CombinationOf2Numbers pair = new CombinationOf2Numbers(10,2);
                pair.Number1 = 12;
                pair.Number2 = 34;
                Console.WriteLine("Paar:" + pair.Number1 + ", " + pair.Number2);
                Console.WriteLine("Som = " + pair.Sum());
                Console.WriteLine("Verschil = " + pair.Difference());
                Console.WriteLine("Product = " + pair.Product());
                Console.WriteLine("Quotient = " + pair.Quotient());
            }

    }
}
