using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
    internal class Triangle
    {
		private double _height = 1.00;
		private double _basis = 1.00;


        public Triangle()
		{

		}

		public Triangle(double basis, double height)
		{
			@Basis = basis;

			Height = height;
		}

        public double @Basis
		{
			get { return _basis; }
			set 
			{
                if (value <= 0)
                {
                    Console.WriteLine($"Het is verboden een Breedte van {value} in te stellen!");
                }
                _basis = value; 
			}
		}

		public double Height
		{
			get { return _height; }
			set 
			{
				if(value <= 0)
				{
					Console.WriteLine($"Het is verboden een Hoogte van {value} in te stellen!");
                }

				_height = value;
			}
		}

        public double Area()
        {
            return (Basis * Height) / 2.0;
        }

    }
}
