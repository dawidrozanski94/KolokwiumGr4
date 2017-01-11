using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwiumGr4
{
    class Lekarz : Osoba
    {
        private string specjalnosc;
    }

    public Lekarz(string imieNazwisko, string specjalnosc)
{
    this.imieNazwisko = imieNazwisko;
    this.specjalnosc = specjalnosc;
}

    public override string daneLekarza()
{
    return "imie i nazwisko " + this.imieNazwisko + ",specjalnosc: " + this.wiek;
}
}
