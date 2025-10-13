using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
    internal class Parrot : Animal
    {
        public override ImmutableList<string> Allergies 
        {
            get { return ImmutableList<string>.Empty; }
        }

        public override void ShowChip()
        {
            Console.WriteLine("Papegaaien worden niet gechipt");
        }
    }
}
