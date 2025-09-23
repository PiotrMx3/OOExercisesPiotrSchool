using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
    internal class CombinationOf2Numbers
    {
        public int Number1;
        public int Number2;

        public CombinationOf2Numbers(int n1, int n2)
        {
            Number1 = n1;
            Number2 = n2;
        }

        public double Sum()
        {
            return Number1 + Number2;
        }

        public double Difference()
        {
            return Number1 - Number2;
        }

        public double Product()
        {
            return Number1 * Number2;
        }

        public double Quotient()
        {
            if (Number2 == 0)
            {
                Console.WriteLine("Fout!");
            }
            return (double)Number1 / Number2;
        }
    }
}
