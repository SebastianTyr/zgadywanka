﻿using System;

namespace ModelGry
{
    public class Gra
    {
        public enum Odp { ZaMalo = -1, Trafiono = 0, ZaDuzo = +1 }; //enum - stale, wartosci = identyfikatory
        public enum StanGry { Trwa, Poddana, Odgadnieta };
        // Pola
        private readonly int wylosowana; //'readonly' - wartość nie może być zmieniana poza konstruktorem!
        public readonly int ZakresOd, ZakresDo;
        public StanGry Stan { get; private set; }

        public int LicznikRuchow { get; private set; } = 0;

        // TODO: historia rozgrywki
        public Gra(int min, int max)
        {
            ZakresOd = min;
            ZakresDo = max;
            wylosowana = Losuj(ZakresOd, ZakresDo);
            Stan = StanGry.Trwa;
        }
        private int Losuj(int min = 1, int max = 100)
        {
            Random generator = new Random();
            int los = generator.Next(min, max + 1);
            return los;
        }
        public Odp Ocena(int propozycja)
        {
            LicznikRuchow++;
            if (propozycja < wylosowana)
                return Odp.ZaMalo;
            else if (propozycja > wylosowana)
                return Odp.ZaDuzo;
            else // ==
            {
                Stan = StanGry.Odgadnieta;
                return Odp.Trafiono;
            }
        }
        public void Poddaj()
        {
            Stan = StanGry.Poddana;
        }
        public int? CoByloWylosowane() // '?' - rozszerzenie typu danych o wartosc 'null'
        {
            if (Stan != StanGry.Trwa)
                return wylosowana;
            else
                return null;
        }
    }
}