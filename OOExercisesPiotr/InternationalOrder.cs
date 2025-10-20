using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
    internal class InternationalOrder : Order
    {
        public InternationalOrder(uint amount, double price) : base(amount, price)
        {
          
        }

        public override double TotalPrice
        {

            get 
            {
                double basicPriceInternational =  base.TotalPrice * 1.10;

                if(Number > 100) return basicPriceInternational - 1000.00;

                return basicPriceInternational;
            }
        }
    }
}
