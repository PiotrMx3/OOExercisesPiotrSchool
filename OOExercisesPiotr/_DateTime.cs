using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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
            Console.WriteLine("1: H10-Clock");
            Console.WriteLine("2: H10-Birthday");
            Console.WriteLine("3: H10-DayOfTheWeek");
            Console.WriteLine("4: H10-TicksSince2000");
            Console.WriteLine("5: H10-LeapYearCount");
            Console.WriteLine("6: H10-CodeTiming");

            string k = Console.ReadLine() ?? "".Trim();

            switch (k)
            {
                case "1":
                    H10Clock();
                    break;
                case "2":
                    H10Birthday();
                    break;
                case "3":
                    H10DayOfTheWeek();
                    break;
                case "4":
                    H10TicksSince2000();
                    break;
                case "5":
                    H10LeapYearCount();
                    break;
                case "6":
                    H10CodeTiming();
                    break;
                default:
                    Console.WriteLine("Verkeerd keuze !");
                break;
            }

            
        }


        public static void H10Clock()
        {
            while (true)
            {
                DateTime seconds = DateTime.Now;
                Console.WriteLine($"{seconds.ToString("T")}");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();

             
            }
        }


        public static void H10Birthday()
        {
            Console.WriteLine("Wat is u geboorte datum ? (DD/MM/JJJJ)");

            DateTime birthday = DateTime.Parse(Console.ReadLine() ?? "01/01/1999");
            DateTime checkBirth= new DateTime(DateTime.Now.Year, birthday.Month, birthday.Day);


            if (checkBirth < DateTime.Now)
            {
                checkBirth = checkBirth.AddYears(1);
            }


            TimeSpan diff = checkBirth - DateTime.Now;

            Console.WriteLine($"Nog {diff.Days} dagen tot jouw verjaardag!");

           
        }

        public static void H10DayOfTheWeek()
        {
            Console.WriteLine("Welke dag ?");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Welke maand ?");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Welke jaar ?");
            int year = Convert.ToInt32(Console.ReadLine());

            DateTime newTime = new DateTime(year, month, day);

            Console.WriteLine($"{newTime:D} is {newTime.DayOfWeek}");
        }

        public static void H10TicksSince2000()
        {
            DateTime oldTime = new DateTime(2000, 1, 1);
            DateTime nowTime = DateTime.Now;

            Console.WriteLine($"Sinds {oldTime:D} zijn er {nowTime.Ticks - oldTime.Ticks} ticks voorbijgegaan");
        }   

        public static void H10LeapYearCount()
        {
            DateTime startTime = new(1799,1,1);
            int counter = 0;

            while (true)
            {
                if(DateTime.IsLeapYear(startTime.Year))
                {
                    counter++;
                }

                if (startTime.Year == 2021) break;

                startTime = startTime.AddYears(1);
            }

            Console.WriteLine($"Er zijn {counter} schrikkeljaren tussen 1799 en 2021.");

        }


        public static void H10CodeTiming()
        {
            DateTime nowTime = DateTime.Now;

            int[] arr = new int[100000];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }

            DateTime afterArr = DateTime.Now;
            TimeSpan diff = afterArr - nowTime;

            Console.WriteLine($"Het duurt {diff.Milliseconds} milliseconden om een array van een miljoen elementen aan te maken en op te vullen met opeenvolgende waarden. ");
        }
    }
}
