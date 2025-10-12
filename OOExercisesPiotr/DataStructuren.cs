using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
    internal class DataStructuren
    {
        public static void ShowSubMenu()
        {
            Console.WriteLine("Uit te voeren oefening ?");
            Console.WriteLine();

            Console.WriteLine("1. H13-PhhoneBookNameNumber");
            Console.WriteLine("2. H13-PhoneBookCityNameNumber");
            Console.WriteLine("3. H13-PhhoneBookNameNumber Builder");






            string userChoice = (Console.ReadLine() ?? "").Trim();

            switch (userChoice)
            {

                case "1":
                    PhoneBookNameNumber();
                    break;
                case "2":
                    PhoneBookCityNameNumber();
                    break;
                case "3":
                    PhoneBookWithBuilder();
                    break;
                default:
                    break;
            }
        }



        private static void PhoneBookWithBuilder()
        {
            ImmutableDictionary<string,string>.Builder phoneBookBuilder = ImmutableDictionary.CreateBuilder<string, string>();

            bool isRunning = true;



            while (isRunning)
            {

                Console.WriteLine("Wil jij een naam en nummer inlezen? (ja/nee)");

                if ((Console.ReadLine() ?? "").ToLower() == "nee") break;
                Console.WriteLine();

                Console.WriteLine($"Naam?");
                string name = (Console.ReadLine() ?? "").ToLower();

                Console.WriteLine($"Nummer?");
                string number = (Console.ReadLine() ?? "").ToLower();

                phoneBookBuilder[name] = number;

            }

            isRunning = false;

            ImmutableDictionary<string, string> immutablePhoneBook = phoneBookBuilder.ToImmutableDictionary<string, string>();


            foreach (var item in immutablePhoneBook)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }


        }

        private static void PhoneBookCityNameNumber()
        {

            Dictionary<string, Dictionary<string, string>> phoneCityBook = new Dictionary<string, Dictionary<string, string>>();


            bool isRunning = true;



            while (isRunning)
            {

                Console.WriteLine("Wil jij een gemeente, naam en nummer inlezen? (ja/nee)");

                if ((Console.ReadLine() ?? "").ToLower() == "nee") break;
                Console.WriteLine();

                Console.WriteLine($"Gemeente");
                string city = (Console.ReadLine() ?? "").ToLower();

                Console.WriteLine($"Naam?");
                string name = (Console.ReadLine() ?? "").ToLower();

                Console.WriteLine($"Nummer?");
                string number = (Console.ReadLine() ?? "").ToLower();

                
                if(!phoneCityBook.ContainsKey(city.ToLower()))
                {
                    phoneCityBook[city] = new Dictionary<string, string>();
                }

                phoneCityBook[city][name] = number;

            }

            isRunning = false;


            foreach (var item in phoneCityBook)
            {
                Console.WriteLine($"Gemeemente - {item.Key}");

                foreach (var value in item.Value)
                {
                    Console.WriteLine($"{value.Key}: {value.Value}");
                }
            }

        }




        private static void PhoneBookNameNumber()
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();


            bool isRunning = true;

      

            while (isRunning)
            {

                Console.WriteLine("Wil jij een naam en nummer inlezen? (ja/nee)");

                if ((Console.ReadLine() ?? "").ToLower() == "nee") break;
                Console.WriteLine();

                Console.WriteLine($"Naam?");
                string name = (Console.ReadLine() ?? "").ToLower();

                Console.WriteLine($"Nummer?");
                string number = (Console.ReadLine() ?? "").ToLower();

                phoneBook[name] = number;

            }

            isRunning = false;


            foreach (var item in phoneBook)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }


    }
}
