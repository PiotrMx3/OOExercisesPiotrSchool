using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
    internal class Cat
    {
		private int _age;

		public int Age
		{
			get { return this._age; }
			private set
			{
				if (value > 25) throw new ArgumentException("Deze kat is te oud !");
				this._age = value;
			}
		}

		public Cat(int age)
		{
			Age = age;
		}
	}
}
