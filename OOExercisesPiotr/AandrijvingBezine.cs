using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOExercisesPiotr.Polymorfisme;

namespace OOExercisesPiotr
{
    internal class AandrijvingBezine : IAandrijving
    {
        public void EnergieToevoegen()
        {
            Console.WriteLine("< EnergieToevoegen > - < AandrijvingBezine >");
        }

        public void Versnellen(int kmPerUurPerSeconde, int doelsnelheid)
        {
            Console.WriteLine("< EnergieToevoegen > - < AandrijvingBezine >");
        }

        public void Vertragen(int kmPerUurPerSeconde, int doelsnelheid)
        {
            Console.WriteLine("< EnergieToevoegen > - < AandrijvingBezine >");
        }
    }
}
