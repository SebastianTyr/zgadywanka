using System;
using System.Collections.Generic;
using System.Text;

namespace ModelGry
{
    public partial class Gra
    {
        //Historia Gry

        public List<Ruch> historia;

        //inner class
        public class Ruch
        {
            public readonly int Propozycja;
            public readonly Odp Odpowiedz;
            public readonly DateTime Kiedy;

            public Ruch(int prop, Odp odp)
            {
                Propozycja = prop;
                Odpowiedz = odp;
                Kiedy = DateTime.Now;
            }

            public override string ToString() => $"({Propozycja}, {Odpowiedz}, {Kiedy})";
        } //koniec wewn klasy Ruch
    }
}
