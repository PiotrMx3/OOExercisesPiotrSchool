using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
    internal class ExceptionHandling
    {
        public static void ShowSubMenu()
        {
            Console.WriteLine("1:  h16 Weekdagen zonder exception");
            Console.WriteLine("2:  h16 Weekdagen met exception");
            Console.WriteLine("3:  h16 Overflow zonder exception");
            Console.WriteLine("4:  h16 Overflow met exception");
            Console.WriteLine("5:  h16 Juiste Index");
            Console.WriteLine("6:  h16 Juiste Index Extra Voorzichtig");
            Console.WriteLine("7:  h16 Leeftijd Kat");
            Console.WriteLine("8:  h16 Leeftijden Katten");
            Console.WriteLine("9:  h16 Filehelper");
            Console.WriteLine("10: h16 Leeftijd Kat Custom");
            Console.WriteLine("11: h16 Gedeeltelijke Afhandeling");








            string c = (Console.ReadLine() ?? "").Trim();
            switch (c)
            {
                case "1":
                    DemonstreerFoutafhandelingWeekdagenZonderException();
                    break;
                case "2":
                    DemonstreerFoutafhandelingWeekdagenMetException();
                    break;
                case "3":
                    DemonstreerFoutafhandelingOverflowZonderException();
                    break;
                case "4":
                    DemonstreerFoutAfhandelingOverflowMetException();
                    break;
                case "5":
                    DemonstreerKeuzeElement();
                    break;
                case "6":
                    DemonstreerKeuzeElementExtraSafe();
                    break;
                case "7":
                    CatDemo();
                    break;
                case "8":
                    DemonstreerLeeftijdKatMetResourceCleanup();
                    break;
                case "9":
                    string outMsg = FileHelper();
                    Console.WriteLine(outMsg);
                    break;
                case "10":
                    KatMetCustomException();
                    break;
                case "11":
                    DemonstreerFormulieren();
                    break;
                default:
                    Console.WriteLine("Ongeldige keuze probeer op het nieuw !");
                    break;
            }
        }



        private static void DemonstreerFormulieren()
        {
            var vraag1 = new FormulierGetalVraag("Hoe oud ben je?", 18, 130);
            var vraag2 = new FormulierVrijeTekstVraag("Hoe ziet jouw ideale dag eruit?");
            var vraag3 = new FormulierGetalVraag("Hoe veel personen heb je ten laste?", 0, 10);
            var vraag4 = new FormulierVrijeTekstVraag("Wie is je idool?");
            Formulier f1 = new Formulier(new List<FormulierVraag> { vraag1, vraag2 });
            Formulier f2 = new Formulier(new List<FormulierVraag> { vraag3, vraag4 });
            try
            {
                f1.VulIn();
                f1.Toon();
            }
            catch (Exception)
            {
                System.Console.WriteLine("We zullen dit formulier weggooien.");
                f1 = null;
            }
            try
            {
                f2.VulIn();
                f2.Toon();
            }
            catch (Exception)
            {
                System.Console.WriteLine("We zullen dit formulier weggooien.");
                f2 = null;
            }
        }

        private static void KatMetCustomException()
        {
            try
            {
                KatMetCustomException kat = new KatMetCustomException(27);
            }
            catch (KatLeeftijdException e)
            {
                Console.WriteLine($"{e.Value} is geen geldige leeftijd. De laagst mogelijke leeftijd is {e.LowValue} jaar, de hoogst mogelijke leeftijd is {e.MaxValue} jaar.");
            }

        }


        private static string FileHelper()
        {
            Console.WriteLine("Welke file wil je lezen ? ");
            string path = Console.ReadLine() ?? "";
            string errorMessage = null;
            string content = null;

            try
            {
                if (string.IsNullOrEmpty(path))
                {
                    return "input was leeg";
                }

                if (!File.Exists($@"{path}"))
                {
                    return "File kon niet gevonden worden";
                }

                string[] f = File.ReadAllLines(path);

                // C:\Users\piotr\TODOC.txt

                content = string.Join("\n", f);
                return content;
            }
            catch (ArgumentException)
            {
                errorMessage = "Fout: Het opgegeven pad is leeg, bevat enkel spaties of ongeldige karakters.";
            }
            catch (PathTooLongException)
            {
                errorMessage = "Fout: Het pad, de bestandsnaam of beide zijn te lang voor het systeem.";
            }
            catch (DirectoryNotFoundException)
            {
                errorMessage = "Fout: De opgegeven map is niet gevonden of het pad is ongeldig (bv. een niet-toegewezen schijf).";
            }
            catch (UnauthorizedAccessException)
            {
                errorMessage = "Fout: U hebt onvoldoende machtigingen of de bewerking wordt niet ondersteund (bv. u probeert een map te lezen als bestand).";
            }
            catch (NotSupportedException)
            {
                errorMessage = "Fout: Het formaat van het pad is niet correct of wordt niet ondersteund.";
            }
            catch (IOException)
            {
                errorMessage = "Fout: Er is een algemene I/O-fout opgetreden tijdens het openen of bewerken van het bestand.";
            }
            catch (Exception)
            {
                errorMessage = "Fout: Er is een onbekende fout opgetreden.";
            }

            return errorMessage;

        }
        private static void DemonstreerLeeftijdKatMetResourceCleanup()
        {

            List<Cat> allCats = new();
            Random r = new();


            while (true)
            {
                try
                {
                    for (int i = 0; i < 20; i++)
                    {
                        Cat kat = new Cat(r.Next(30));
                        allCats.Add(kat);
                    }

                    Console.WriteLine("De volledige lijst met katten is aangemaakt!");
                    break;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Het is niet gelukt :-(");
                }
                finally
                {
                    allCats.Clear();
                }

            }

        }

        private static void CatDemo()
        {
            try
            {
                Cat kat = new Cat(27);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }
        private static void DemonstreerKeuzeElementExtraSafe()
        {
            Random r = new();

            int[] array = new int[3];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(10);
            }

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Geef de index van het getal dat je wil zien");
                string indexChoice = Console.ReadLine() ?? "";

                try
                {
                    Console.WriteLine($"Het getal is {array[Convert.ToInt16(indexChoice)]}");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Ups deze index hebben we niet!");
                }


                Console.WriteLine("Wil je doorgaan ? (ja/nee)");
                string answer = Console.ReadLine() ?? "";

                if (answer.ToLower() != "ja")
                {
                    isRunning = false;
                }
            }
        }


        private static void DemonstreerKeuzeElement()
        {
            Random r = new();

            int[] array = new int[3];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(10);
            }

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Geef de index van het getal dat je wil zien");
                string indexChoice = Console.ReadLine() ?? "";

                try
                {
                    Console.WriteLine($"Het getal is {array[Convert.ToInt16(indexChoice)]}");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Ups deze index hebben we niet!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ups het ingegeven getal is te groot!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ups ingegeven data was geen geheel getal1");
                }
                catch (Exception)
                {
                    Console.WriteLine("Ups een algemeen fout is opgetreden!");
                }


                Console.WriteLine("Wil je doorgaan ? (ja/nee)");
                string answer = Console.ReadLine() ?? "";

                if (answer.ToLower() != "ja")
                {
                    isRunning = false;
                }
            }
        }
        private static void DemonstreerFoutAfhandelingOverflowMetException()
        {
            try
            {
                int num1, num2;
                byte resultaat;
                num1 = 30;
                num2 = 60;
                resultaat = Convert.ToByte(num1 * num2);
                Console.WriteLine("{0} x {1} = {2}", num1, num2, resultaat);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Het getal is te groot om te converteren naar het gewenste formaat.");
            }
        }

        private static void DemonstreerFoutafhandelingOverflowZonderException()
        {
            int num1, num2;
            int resultaat;
            num1 = 30;
            num2 = 60;
            resultaat = num1 * num2;
            Console.WriteLine("{0} x {1} = {2}", num1, num2, resultaat);
        }

        private static void DemonstreerFoutafhandelingWeekdagenMetException()
        {
            try
            {
                string[] arr = new string[5];
                arr[0] = "Vrijdag";
                arr[1] = "Maandag";
                arr[2] = "Dinsdag";
                arr[3] = "Woensdag";
                arr[4] = "Donderdag";

                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(arr[i].ToString());
                }
            }
            catch (IndexOutOfRangeException)
            {

            }
        }

        private static void DemonstreerFoutafhandelingWeekdagenZonderException()
        {
            string[] arr = new string[5];
            arr[0] = "Vrijdag";
            arr[1] = "Maandag";
            arr[2] = "Dinsdag";
            arr[3] = "Woensdag";
            arr[4] = "Donderdag";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i].ToString());
            }
        }


    }
}
