using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
    internal class Stoomketel : Ketel, Polymorfisme.IStoomVerwarmen, Polymorfisme.IAfkoelen, Polymorfisme.IWaterDoseren
    {
        public Stoomketel(int volume) : base(volume)
        {
        }

        public void Afkoelen(int doelTemperatuur)
        {
            Console.WriteLine($"{this} - Afkoelen");
        }

        public void StoomVerwarmen(int doelTemperatuur)
        {
            Console.WriteLine($"{this} - Stoom Verwarmen");

        }

        public void WaterDoseren(int hoeveelheid)
        {
            Console.WriteLine($"{this} - Water Doseren");

        }
    }
}
