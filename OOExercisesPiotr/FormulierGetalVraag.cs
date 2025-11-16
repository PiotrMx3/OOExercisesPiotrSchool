using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
    internal class FormulierGetalVraag : FormulierVraag
    {
        private int _onderGrens;
        private int _bovenGrens;

        public FormulierGetalVraag(string tekst, int onderGrens, int bovenGrens) : base(tekst)
        {
            BovenGrens = bovenGrens;
            OnderGrens = onderGrens;
        }
        public int BovenGrens
        {
            get { return this._bovenGrens; }
            private set { this._bovenGrens = value; }
        }


        public int OnderGrens
        {
            get { return this._onderGrens; }
            private set
            {
                if (value > BovenGrens) throw new ArgumentException("Ondergrens mag niet hooger zijn dan Bovengrens.");
                this._onderGrens = value;
            }
        }


        public override void LeesAntwoord()
        {
            bool isRunning = true;

            while (isRunning)
            {
                string userAnswer = (Console.ReadLine() ?? "").Trim();

                if (int.TryParse(userAnswer, out int result) && result >= OnderGrens && result <= BovenGrens)
                {
                    Antwoord = userAnswer;
                    isRunning = false;
                }
                else
                {
                    Console.WriteLine($"Je antwoord moet tussen {OnderGrens} en {BovenGrens} liggen");
                }

            }
        }

        public override void ToonVraag()
        {
            Console.WriteLine($"{Tekst}\n" +
                $"Dat is een getal tussen {OnderGrens} en {BovenGrens}");
        }
    }
}
