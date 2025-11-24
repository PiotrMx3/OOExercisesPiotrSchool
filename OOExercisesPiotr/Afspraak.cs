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

		public Afspraak()
		{

		}
		public Afspraak(TimeSpan movingTime, TimeSpan comingBackTime, TimeSpan duration, string description)
		{
			MovingTime = movingTime;
			ComingBackTime = comingBackTime;
			Duration = duration;
			Description = description;
		}

		public string Description
		{
			get { return this._description; }
			private set { this._description = value; }
		}


		public TimeSpan Duration
		{
			get { return this._duration; }
			private set { this._duration = value; }
		}


		public TimeSpan ComingBackTime
		{
			get { return this._comingBackTime; }
			private set { this._comingBackTime = value; }
		}

		public TimeSpan MovingTime
		{
			get { return this._movingTime; }
			private set { this._movingTime = value; }
		}

        public TimeSpan Tijdsduur
		{
			get { return (Duration + MovingTime + ComingBackTime); }
		}

        public string Omschrijving
        {
            get { return $" PM:{Description}"; }
        }

        public void Initialiseer()
        {
            Console.WriteLine("Omschrijving ?");
            string userDescription = Console.ReadLine() ?? "";
            Console.WriteLine();

            Console.WriteLine("Aantal minuten verplaatsing ?");
            int userMovingTime = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Aantal minuten afspraak zelf ?");
            int userAppointmentDuration = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Aantal minuten om terug te keren ?");
            int userComingBackTime = Convert.ToInt32(Console.ReadLine());

            MovingTime = new TimeSpan(0,userMovingTime,0);
			ComingBackTime = new TimeSpan(0, userComingBackTime, 0);
            Duration = new TimeSpan(0, userAppointmentDuration, 0);
            Description = userDescription;
        }

        public DateTime RoosterOm(DateTime referentiepunt)
        {

			DateTime timeAppointment = referentiepunt;

			timeAppointment = timeAppointment.AddMinutes(-MovingTime.Minutes);

			return timeAppointment;
        }
    }
}
