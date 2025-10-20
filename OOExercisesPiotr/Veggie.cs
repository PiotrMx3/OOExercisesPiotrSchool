using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
    internal class Veggie : Pizza
    {
        public Veggie(string[] extraToppings) : base(extraToppings)
        {
            Ingredients.Remove("kaas");
        }

        public override double UnitPrice 
        {
            get { return 6.00; }
        }
    }
}
