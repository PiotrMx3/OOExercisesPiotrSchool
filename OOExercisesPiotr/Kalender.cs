using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
    internal class Kalender
    {
		private string _name = "";
		private Dictionary<DateTime,Polymorfisme.IRoosterbaar> _event = new();

		public Kalender(string name)
		{
			Name = name;
		}
		public ImmutableDictionary<DateTime,Polymorfisme.IRoosterbaar> Event
		{
			get { return this._event.ToImmutableDictionary(); }
		}

		public string Name
		{
			get { return this._name; }
			private set { this._name = value; }
		}


		public void Voegtoe()
		{
			bool isRunning = true;

			while (isRunning)
			{
				Console.WriteLine("Om wat voor object gaat het ?");
				Console.WriteLine("1. Afspraak");
				Console.WriteLine("2. Taak");

				string userInput = Console.ReadLine() ?? "";
				Console.WriteLine();


				if(userInput == "1")
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


                    Console.WriteLine("Wanneer moet dit geroosterd worden ?");
					string userAppointmentDate = Console.ReadLine() ?? "";

					Afspraak newA = new Afspraak(new TimeSpan(0,userMovingTime,0), new TimeSpan(0,userComingBackTime,0), new TimeSpan(0,userAppointmentDuration,0), userDescription);

					DateTime timeAppointment = DateTime.Parse(userAppointmentDate);

					timeAppointment = timeAppointment.AddMinutes(-userMovingTime);

					_event.Add(timeAppointment, newA);

					
                }
                else if(userInput == "2")
				{
                    Console.WriteLine("Omschrijving ?");
                    string userDescription = Console.ReadLine() ?? "";
                    Console.WriteLine();

                    Console.WriteLine("Aantal minuten werk ?");
                    int userTaskTime = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("Wanneer moet dit geroosterd worden ?");
                    string userAppointmentDate = Console.ReadLine() ?? "";

                    Taak newT = new Taak(new TimeSpan(0, userTaskTime, 0), userDescription);

                    DateTime timeAppointment = DateTime.Parse(userAppointmentDate);

                    timeAppointment = timeAppointment.AddMinutes(-userTaskTime);

                    _event.Add(timeAppointment, newT);
                }
				else
				{
					Console.WriteLine("Ongeldige keuze !");
					continue;
				}


				Console.WriteLine("Wil jij nog een item toevoegen? (ja/nee)");
				userInput = Console.ReadLine() ?? "";

				if(userInput != "ja")
				{
					isRunning = false;
					Console.WriteLine("Programma wordt afgesloten");
				}

				
			}


			foreach (var item in Event)
			{
				Console.WriteLine($"{item.Key.ToString("dd/MM/yyyy HH:mm:ss")}{item.Value.Omschrijving}");
			}


        }


    }
}
