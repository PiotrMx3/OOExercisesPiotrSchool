using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
    internal class RegisteredLetter
    {
		private double _distance;
		private double _price;

		public virtual double Price
		{
			get
			{
				double basisPrice = 15.00;

				if(Distance < 100) return _price = basisPrice;

                _price = (10 * ((int)Distance / 100));

                return _price;
            }
		}
		public virtual byte Duration
		{
			get
			{
				double standardDuration = 100.00;

				return (byte)Math.Ceiling((Distance / standardDuration)); 
			}
		}


		public double Distance
		{
			get { return this._distance; }
			set
			{
				if (value <= 0)
				{
					Console.WriteLine("Afstaand moet hooger zijn dan 0");
					return;
				}

				this._distance = value; 
			}
		}

	}
}
