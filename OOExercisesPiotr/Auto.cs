using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOExercisesPiotr.Polymorfisme;

namespace OOExercisesPiotr
{
    internal class Auto
    {
		private string _autoType = "";
		private IAandrijving _engie;

		public Auto(string autoType, IAandrijving engine)
		{
			AutoType = autoType;
			Engine = engine;
		}

		public IAandrijving Engine
		{
			get { return this._engie; }
			private set { this._engie = value; }
		}


		public string AutoType
		{
			get { return this._autoType; }
			private set { this._autoType = value; }
		}

	}
}
