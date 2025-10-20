using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
    internal class ChildrenMeal : Meal
    {
        public ChildrenMeal(string name, double price) : base(name, price)
        {
        }
        public override void ShowTheMenu()
        {
            Random random = new Random();

            int randnr = random.Next(0, 16);

            Console.ForegroundColor = (ConsoleColor)randnr;
            base.ShowTheMenu();
            Console.ResetColor();
        }
    }
}
