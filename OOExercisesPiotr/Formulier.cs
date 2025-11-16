using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
    internal class Formulier
    {
        private List<FormulierVraag> _vragen = new();

        public Formulier(List<FormulierVraag> vragen)
        {
            _vragen.AddRange(vragen);
        }
        public ImmutableList<FormulierVraag> Vragen
        {
            get { return this._vragen.ToImmutableList(); }
        }

        public void VulIn()
        {
            try
            {
                foreach (var item in Vragen)
                {
                    item.ToonVraag();
                    item.LeesAntwoord();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Onverwachte fout wordt naar schijf weggeschreven.");
                throw;
            }

        }

        public void Toon()
        {
            foreach (var item in Vragen)
            {
                Console.WriteLine($"Vraag: {item.Tekst}\n" +
                    $"Antwoord: {item.Antwoord ?? "Geen Antwoord ingevuld"}");
            }
        }
    }

}
