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


            string k = Console.ReadLine() ?? "".Trim();

            switch (k)
            {
                case "1":
                    _DateTime.ShowSubmenu();
                    break;

                default:
                    Console.WriteLine("verkeerde keuze");
                    break; 

            }

            
        }
        
    }
}
