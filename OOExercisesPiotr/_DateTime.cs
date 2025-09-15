using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
    internal class _DateTime
    {
        public static void ShowSubmenu()
        {

            Console.WriteLine("Uit te voeren oefening?");
            Console.WriteLine("H10-Clock");
            Console.WriteLine("H10-Birthday");
            Console.WriteLine("H10-DayOfTheWeek");
            Console.WriteLine("H10-TicksSince2000");
            Console.WriteLine("H10-LeapYearCount");
            Console.WriteLine("H10-CodeTiming");
            Console.WriteLine("H10-CodeTiming");

            string k = Console.ReadLine() ?? "".Trim();

            switch (k)
            {
                case "1":
                    //TODO: H10-Clock
                    break;
                default:
                    Console.WriteLine("Verkeerd keuze !");
                    break;
            }


        }
    }
}
