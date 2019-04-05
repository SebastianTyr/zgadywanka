using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraMonolitycznie
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Witaj");
            Console.Write("Podaj swoje imię: ");
            string x = Console.ReadLine();
            Console.WriteLine($"Witaj {x}");
            */

            //1. Komputer losuje liczbę
            Random generator = new Random();
            int wylosowana = generator.Next(1, 101);
            Console.WriteLine("Wylosowałem liczbę od 1 do 100. \nOdgadnij ją");

#if(DEBUG)
            Console.WriteLine(wylosowana);
#endif
            //wykonuj
            bool trafiono = false; //wartownik (zwany czasami flagą)
            do
            {
                #region Krok 2. Człowiek proponuje rozwiązanie
                Console.Write("Podaj swoją propozycję: ");
                string tekst = Console.ReadLine();
                if (tekst.ToLower() == "x")
                    break;

                int propozycja = 0;
                try
                {
                    propozycja = Convert.ToInt32(tekst);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nie podano liczby !");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Podana liczba nie mieści się w rejestrze !");
                    continue;
                }

                Console.WriteLine($"Przyjąłem wartość {propozycja}");
                #endregion

                #region Krok 3. Komputer ocenia propozycję
                if (propozycja < wylosowana)
                    Console.WriteLine("Za mało");
                else if (propozycja > wylosowana)
                    Console.WriteLine("Za dużo");
                else
                {
                    Console.WriteLine("Trafiono");
                    trafiono = true;
                }
                #endregion
            } while (!trafiono);
            //do momentu trafienia

            Console.WriteLine("Koniec gry");
        }
    }
}
