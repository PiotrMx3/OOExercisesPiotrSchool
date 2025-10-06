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
            Console.WriteLine("3: Data Structurne");


            string k = Console.ReadLine() ?? "".Trim();

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

                default:
                    Console.WriteLine("verkeerde keuze");
                    break; 

            }

            
        }
        
    }
}
