using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
    internal class Polymorfisme
    {
        public static void ShowSubenu()
        {
            Console.WriteLine("1.h17 Autoconstructeur ");
            Console.WriteLine("2.h17 Grootkeuken ");
            Console.WriteLine("3.h17 Rooster Stap 1");


            string choice = (Console.ReadLine() ?? "").Trim();

            switch (choice)
            {
                case "1":
                    CarConstructor();
                    break;
                case "2":
                    DemonstreerGrootkeuken();
                    break;
                case "3":
                    DemonstreerIRoosterbaar();
                    break;
                default:
                    Console.WriteLine("verkeerde keuze");
                    break;
            }
        }


        public static void DemonstreerIRoosterbaar()
        {
            IRoosterbaar blok1 = new Afspraak(new TimeSpan(0, 20, 0), new TimeSpan(1, 0, 0), new TimeSpan(0, 20, 0), "tandarts");
            IRoosterbaar blok2 = new Taak(new TimeSpan(2, 0, 0), "dagelijkse oefeningen OOP");
            System.Console.WriteLine($"Totale kalendertijd: {(blok1.Tijdsduur + blok2.Tijdsduur).Hours}u{(blok1.Tijdsduur + blok2.Tijdsduur).Minutes}m");
        }


        public interface IRoosterbaar
        {
            TimeSpan Tijdsduur { get; }
            string Omschrijving { get; }

        }



        public static void DemonstreerGrootkeuken()
        {
            Stoomketel k1 = new Stoomketel(300);
            Stoomketel k2 = new Stoomketel(300);
            KetelZonderDoseren k3 = new KetelZonderDoseren(150);
            KetelZonderDoseren k4 = new KetelZonderDoseren(300);
            KetelMetDoseren k5 = new KetelMetDoseren(200);
            KetelMetDoseren k6 = new KetelMetDoseren(150);

            k1.StoomVerwarmen(2);
            k2.Afkoelen(2);
            k3.Vermamen(2);
            k5.WaterDoseren(2);

        }


        public interface IVerwarmen
        {
            void Vermamen(int doelTemperatuur);
        }

        public interface IAfkoelen
        {
            void Afkoelen(int doelTemperatuur);

        }
        public interface IStoomVerwarmen
        {
            void StoomVerwarmen(int doelTemperatuur);
        }
        public interface IWaterDoseren
        {
            void WaterDoseren(int hoeveelheid);
        }





        public interface IAandrijving
        {
            void EnergieToevoegen();

            void Vertragen(int kmPerUurPerSeconde, int doelsnelheid);

            void Versnellen(int kmPerUurPerSeconde, int doelsnelheid);
        }

        private static void CarConstructor()
        {
            Auto new1 = new Auto("Benzine", new AandrijvingBezine());
            Auto new2 = new Auto("Benzine", new AandrijvingElekrisch());

            new1.Engine.EnergieToevoegen();
            new2.Engine.EnergieToevoegen();

        }

    }
}
