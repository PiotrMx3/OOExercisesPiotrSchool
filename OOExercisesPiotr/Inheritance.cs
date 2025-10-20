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
                Console.WriteLine("3. H15-Orders");
                Console.WriteLine("4. H15-Pizza");
                Console.WriteLine("5. H15-ChildMenu");

                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        DemoPostOffice();
                        break;

                    case 2:
                        DemoVet();
                        break;
                    case 3:
                        DemoOrder();
                        break;
                    case 4:
                        DemoPizza();
                        break;
                    case 5:
                        ChildMenu();
                        break;

                    default:
                        Console.WriteLine("Ongeldige keuze!");
                        break;
                }

                isRunning = false;
            }


        }

        public static void ChildMenu()
        {
            List<Meal> list = new List<Meal>();

            list.Add(new Meal("Paling in het groen", 22.00));
            list.Add(new ChildrenMeal("Kinder Vol-au-Vent", 11.00));
            list.Add(new Meal("Waterzooi", 22.00));
            list.Add(new ChildrenMeal("Kabouterschnitzel", 12.00));


            foreach (var item in list)
            {
                item.ShowTheMenu();
            }

        }

        public static void DemoPizza()
        {

            Margherita margherita = new Margherita(["mozzarella"]);

            Console.WriteLine($"Een margerita zonder extra`s kost {margherita.Price}");
            margherita.ShowIngredients();

            Console.WriteLine();

            Veggie veggie = new Veggie(["tofu", "spinaze"]);
            Console.WriteLine($"Een veggie zonder extra`s kost {veggie.Price}");
            veggie.ShowIngredients();
            

        }

        public static void DemoOrder()
        {
            Console.WriteLine("Aantal stuks ?");
            uint amount = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Basisprijs ?");
            double basisPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Gewone bestelling (1) of interntionale bestelling (2) ?");

            string choice = Console.ReadLine();



            if(choice == "1")
            {
                Order newOrder = new Order(amount, basisPrice);
                Console.WriteLine($"Totaalprijs: {newOrder.TotalPrice:F2} ");

                return;
            }

            if (choice == "2")
            {
                InternationalOrder newOrder = new InternationalOrder(amount, basisPrice);
                Console.WriteLine($"Totaalprijs: {newOrder.TotalPrice:F2} ");

                return;
            }

            Console.WriteLine("Verkeerde keuze !");
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
