using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOExercisesPiotr.Polymorfisme;

namespace OOExercisesPiotr
{
    internal class Afspraak : IRoosterbaar
    {
		private TimeSpan _movingTime;
		private TimeSpan _comingBackTime;
		private TimeSpan _duration;
		private string _description = "";

		public Afspraak(TimeSpan movingTime, TimeSpan comingBackTime, TimeSpan duration, string description)
		{
			MovingTime = movingTime;
			ComingBackTime = comingBackTime;
			Duration = duration;
			Description = description;
		}

		public string Description
		{
			get { return _description; }
			private set { _description = value; }
		}


		public TimeSpan Duration
		{
			get { return _duration; }
			private set { _duration = value; }
		}


		public TimeSpan ComingBackTime
		{
			get { return _comingBackTime; }
			private set { _comingBackTime = value; }
		}

		public TimeSpan MovingTime
		{
			get { return _movingTime; }
			private set { _movingTime = value; }
		}

        public TimeSpan Tijdsduur
		{
			get { return (Duration + MovingTime + ComingBackTime); }
		}

        public string Omschrijving
        {
            get { return Description; }
        }
    }
}
