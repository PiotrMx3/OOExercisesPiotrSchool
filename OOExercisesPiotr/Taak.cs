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

		public Taak()
		{

		}
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
            get { return $" PM:{Description}"; }
        }

        public void Initialiseer()
        {
            Console.WriteLine("Omschrijving ?");
            string userDescription = Console.ReadLine() ?? "";
            Console.WriteLine();

            Console.WriteLine("Aantal minuten werk ?");
            int userTaskTime = Convert.ToInt32(Console.ReadLine());


            TaskDuration = new TimeSpan(0,userTaskTime,0);
            Description = userDescription;

        }

        public DateTime RoosterOm(DateTime referentiepunt)
        {
			return referentiepunt;
        }
    }
}
