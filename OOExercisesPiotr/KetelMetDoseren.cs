using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
    internal class KetelMetDoseren : Ketel, Polymorfisme.IVerwarmen, Polymorfisme.IWaterDoseren
    {
        public KetelMetDoseren(int volume) : base(volume)
        {
        }

        public void Vermamen(int doelTemperatuur)
        {
            Console.WriteLine($"{this} - Vermamen");

        }

        public void WaterDoseren(int hoeveelheid)
        {
            Console.WriteLine($"{this} - Water Doseren");

        }
    }
}
