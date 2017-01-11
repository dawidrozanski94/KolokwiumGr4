using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwiumGr4
{
    abstract class Osoba
    {
        protected string imieNazwisko;

        public Osoba(string imieNazwisko)
        {
            this.imieNazwisko = imieNazwisko;
        }

        public abstract string danePacjenta()
        {
            return imieNazwisko;
        }
    }
}
