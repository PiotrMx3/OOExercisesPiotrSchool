using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
    internal class Dog : Animal
    {

        private List<string> _invidualAllergies = new List<string>() { "druiven", "noten", "chocolade", "avocado"};
        private string _chip;

        public string Chip
        {
            get { return _chip; }
            set { _chip = value; }
        }


        public List<string> IndividualAllergies
        {
            get { return _invidualAllergies; }
            set { _invidualAllergies.AddRange(value); }
        }

        public override ImmutableList<string> Allergies
        {
            get { return IndividualAllergies.ToImmutableList<string>(); }
        }

        public override void ShowChip()
        {
            Console.WriteLine($"{this._chip}");
        }
    }
}
