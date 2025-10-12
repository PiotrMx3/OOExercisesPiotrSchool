using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
    internal class HighPriorityRegisteredLetter : RegisteredLetter
    {
        private double _totalPrice;

        public override byte Duration
        {
            get
            {
                return (byte)(base.Duration / 2);
            }
        }

        public override double Price
        {
            get
            {
                double basisPrice = 30.00;

                if (Distance < 100) return _totalPrice = basisPrice;

                _totalPrice = (30 * ((int)Distance / 100));

                return _totalPrice;
            }
        }
    }
}
