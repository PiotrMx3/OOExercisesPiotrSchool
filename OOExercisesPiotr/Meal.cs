using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
    internal class Meal
    {
		private string _name = null!;
		private double _price;

		public Meal(string name, double price)
		{
			Name = name;
			Price = price;
		}

		public double Price
		{
			get { return this._price; }
			set { this._price = value; }
		}

		public string Name
		{
			get { return this._name; }
			set { this._name = value; }
		}

		public virtual void ShowTheMenu()
		{
			Console.WriteLine($"{Name,-35}{Price:F0}");
		}

	}
}
