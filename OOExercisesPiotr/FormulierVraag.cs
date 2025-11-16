using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
    internal abstract class FormulierVraag
    {
        private string _tekst;
        private string? _antwoord = null;

        public FormulierVraag(string tekst)
        {
            Tekst = tekst;
        }

        public string? Antwoord
        {
            get { return this._antwoord; }
            protected set { this._antwoord = value; }
        }


        public string Tekst
        {
            get { return this._tekst; }
            protected set
            {
                if (value is null || string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Vraag mag nooit leeg zijn !");
                this._tekst = value;
            }
        }
        public abstract void LeesAntwoord();
        public abstract void ToonVraag();

    }
}
