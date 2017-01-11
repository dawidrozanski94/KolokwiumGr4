using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwiumGr4
{
    class Pacjent : Osoba
    {
        private int wiek;
        private string choroba;

        public Pacjent(string imieNazwisko, int wiek, string choroba)
        {
            this.imieNazwisko = imieNazwisko;
            this.wiek = wiek;
            this.choroba = choroba;
        }

        public override string danePacjenta()
        {
            return "imie i nazwisko " + this.imieNazwisko + ",wiek: " + this.wiek + ",choroba: " + this.choroba;
        }
    }
}
