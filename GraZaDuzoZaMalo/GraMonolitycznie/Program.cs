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

            //2. Człowiek proponuje rozwiązanie
            Console.Write("Podaj swoją propozycję: ");
            string tekst = Console.ReadLine();
            int propozycja = Convert.ToInt32(tekst);
            Console.WriteLine($"Podałeś wartość {propozycja}");

            //3. Komputer ocenia propozycję
            if (propozycja < wylosowana)
                Console.WriteLine("Za mało");
            else if (propozycja > wylosowana)
                Console.WriteLine("Za dużo");
            else
                Console.WriteLine("Trafiono");

            Console.WriteLine("Koniec gry");
        }
    }
}
