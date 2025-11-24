using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
    internal class KetelZonderDoseren : Ketel , Polymorfisme.IVerwarmen
    {
        public KetelZonderDoseren(int volume) : base(volume)
        {
        }

        public void Vermamen(int doelTemperatuur)
        {
            Console.WriteLine($"{this} - Vermamen");

        }
    }
}
