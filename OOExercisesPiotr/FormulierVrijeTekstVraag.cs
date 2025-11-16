using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
    internal class FormulierVrijeTekstVraag : FormulierVraag
    {
        public FormulierVrijeTekstVraag(string tekst) : base(tekst)
        {
        }

        public override void LeesAntwoord()
        {
            string userAnswer = (Console.ReadLine() ?? "").Trim();

            if (userAnswer == "") return;
            Antwoord = userAnswer;
        }

        public override void ToonVraag()
        {
            Console.WriteLine($"{Tekst}");
            Console.WriteLine("Sluit af met ENTER");
        }
    }
}
