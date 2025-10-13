using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
	enum Genders {Male, Female }
    internal abstract class Animal
    {
		private string _name;
		private Genders _gender;
		
		public abstract ImmutableList<string> Allergies { get; }
		public abstract void ShowChip();

        public Genders Gender
		{
			get { return _gender; }
			set { _gender = value; }
		}


		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

	}
}
