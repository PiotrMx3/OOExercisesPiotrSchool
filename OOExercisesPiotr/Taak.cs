using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOExercisesPiotr.Polymorfisme;

namespace OOExercisesPiotr
{
    internal class Taak : IRoosterbaar
    {
		private TimeSpan _taskDuration;
		private string _description = "";


		public Taak(TimeSpan taksDuration, string description)
		{
			TaskDuration = taksDuration;
			Description = description;
		}
		public string Description
		{
			get { return _description; }
			private set { _description = value; }
		}


		public TimeSpan TaskDuration
		{
			get { return _taskDuration; }
			private set { _taskDuration = value; }
		}

        public TimeSpan Tijdsduur
		{
			get { return TaskDuration; }
		}

        public string Omschrijving
		{
			get { return Description; }
		}
    }
}
