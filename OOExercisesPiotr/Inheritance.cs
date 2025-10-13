using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
    internal class Inheritance
    {
        public static void ShowSubMenu()
        {
            bool isRunning = true;
            int choice;

            while (isRunning)
            {
                Console.WriteLine("Uit te voeren oefening?");
                Console.WriteLine("1. H14-DemoPostOffice");
                Console.WriteLine("2. H14-Veterinarian");

                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        DemoPostOffice();
                        break;

                    case 2:
                        DemoVet();
                        break;

                    default:
                        Console.WriteLine("Ongeldige keuze!");
                        break;
                }

                isRunning = false;
            }


        }


        public static void DemoVet()
        {
            var patients = new List<Animal>();
            var animal1 = new Dog();
            animal1.IndividualAllergies = new List<string> { "vis" };
            animal1.Chip = "ABC123";
            animal1.Gender = Genders.Female;
            animal1.Name = "Misty";
            patients.Add(animal1);
            var animal2 = new Parrot();
            animal2.Gender = Genders.Male;
            animal2.Name = "Coco";
            patients.Add(animal2);
            foreach (var animal in patients)
            {
                Console.WriteLine(animal.Name);
                Console.WriteLine(animal.Gender);
                Console.WriteLine("allergieën:");
                foreach (var allergie in animal.Allergies)
                {
                    Console.WriteLine(allergie);
                }
                animal.ShowChip();
            }
        }



        public static void DemoPostOffice()
        {
            List<RegisteredLetter> letters = new List<RegisteredLetter>();
            bool isRunning = true;

            Console.WriteLine("Wil jij nog een brief toevoegen ? (ja/nee)");
            string goOn = (Console.ReadLine() ?? "").Trim();


            while (isRunning)
            {

                if (goOn.ToLower() == "nee")
                {
                    isRunning = false;
                }
                else
                {

                    Console.WriteLine("Wat voor brief wil je toevoegen?");
                    Console.WriteLine("1. standaard");
                    Console.WriteLine("2. internationaal");
                    Console.WriteLine("3. hoge prioriteit ");
                    Console.WriteLine("4. geen enkele, we zijn klaar met invoeren");

                    string choice = (Console.ReadLine() ?? "").Trim();

                    if(choice == "4")
                    {
                        isRunning = false;
                    }
                    else
                    {
                        Console.WriteLine("Hoe ver moet deze brief");
                        double howFar = Convert.ToDouble(Console.ReadLine());

                        switch (choice)
                        {
                            case "1":
                                RegisteredLetter standardLetter = new RegisteredLetter();
                                standardLetter.Distance = howFar;
                                letters.Add(standardLetter);
                                break;
                            case "2":
                                InternationalRegisteredLetter internationalLetter = new InternationalRegisteredLetter();
                                internationalLetter.Distance = howFar;
                                letters.Add(internationalLetter);
                                break;
                            case "3":
                                HighPriorityRegisteredLetter highPriorLetter = new HighPriorityRegisteredLetter();
                                highPriorLetter.Distance = howFar;
                                letters.Add(highPriorLetter);
                                break;
                        }
                    }
                }
            }

            int counter = 1;
            foreach (RegisteredLetter letter in letters)
            {
                Console.WriteLine($"Brief {counter}: {letter.Distance}km, reistijd {letter.Duration} dagen, kostprijs {letter.Price} euro");
                counter++;
            }
        }
    }
}
