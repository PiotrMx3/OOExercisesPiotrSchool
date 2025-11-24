using System.Security.Cryptography.X509Certificates;

namespace OOExercisesPiotr
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welkom bij de oefeningen van Objectgeoriënteerd Programmeren!");
            Console.WriteLine("Topic van de uit te voeren oefening?");
            Console.WriteLine("1: DateTime");
            Console.WriteLine("2: Classes And Objects");
            Console.WriteLine("3: Data Structuren");
            Console.WriteLine("4: Overerving ");
            Console.WriteLine("5: Exception Afhandeling ");
            Console.WriteLine("6: Polymorfisme ");




            string k = (Console.ReadLine() ?? "").Trim();

            switch (k)
            {
                case "1":
                    _DateTime.ShowSubmenu();
                    break;
                case "2":
                    ClassesAndObjects.ShowSubmenu();
                    break;

                case "3":
                    DataStructuren.ShowSubMenu();
                    break;

                case "4":
                    Inheritance.ShowSubMenu();
                    break;
                case "5":
                    ExceptionHandling.ShowSubMenu();
                    break;
                case "6":
                    Polymorfisme.ShowSubenu();
                    break;
                default:
                    Console.WriteLine("verkeerde keuze");
                    break; 

            }

            
        }
        
    }
}
