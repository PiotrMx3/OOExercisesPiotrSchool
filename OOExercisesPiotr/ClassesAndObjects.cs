using System;
using System.Collections.Generic;
using System.Drawing;
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
            Console.WriteLine("2: FiguresWithConstructor ");

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
                case "2":
                    DemoFiguresWithConstructor();
                    break;
                default:
                    Console.WriteLine("Verkeerd keuze !");
                    break;
            }




        }


        private static void DemoFiguresWithConstructor()
        {
            
            Rectangle r0 = new Rectangle(-1, 2); // breedte fout
            Rectangle r1 = new Rectangle(2.2, 1.5);
            Rectangle r2 = new Rectangle(3, 1);

            Triangle t0 = new Triangle(3, 0);    // hoogte fout
            Triangle t1 = new Triangle(3, 1);
            Triangle t2 = new Triangle(2, 2);

            Console.WriteLine($"Een rechthoek met een breedte van {r1.Width}m en een hoogte van {r1.Height}m heeft een oppervlakte van {r1.Area():0.0}m2.");
            Console.WriteLine($"Een rechthoek met een breedte van {r2.Width}m en een hoogte van {r2.Height}m heeft een oppervlakte van {r2.Area():0.0}m2.");
            Console.WriteLine($"Een driehoek met een basis van {t1.Basis}m en een hoogte van {t1.Height}m heeft een oppervlakte van {t1.Area():0.0}m2.");
            Console.WriteLine($"Een driehoek met een basis van {t2.Basis}m en een hoogte van {t2.Height}m heeft een oppervlakte van {t2.Area():0.0}m2.");
        }

        private static void DemoCombinationOf2Numbers()
        {
            CombinationOf2Numbers pair = new CombinationOf2Numbers();
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
