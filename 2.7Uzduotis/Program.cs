using System;
using System.Transactions;

namespace zvakes
{
    public class Program
    {
        // Įmonė parduoda žvakes po 1 EUR. Perkant daugiau kaip 1000 vienetų taikoma 3 % nuolaida, daugiau kaip 2000 vienetų- 4 % nuolaida.
        // Parašykite programą, kuri skaičiuos žvakių kainą ir atspausdintų atsakymą kiek žvakių ir kokia kaina perkama.
        // Žvakių kiekį generuokite new Random() funkcija nuo 5 iki 3000.
        public static void Main(string[] args)
        {
            Random rnd = new Random();

            int zkiekis = rnd.Next(5, 3000);
            double kaina = 1;
            


            if (zkiekis > 1000)
            {
                kaina *= 0.97;
            }    

            else if (zkiekis > 2000)
            {
                kaina *= 0.96;
            }

            double viso = zkiekis * kaina;


            Console.WriteLine("Žvakių kaina 1 EUR, 1000vnt.+ - taikome 3% nuolaidą, 2000+ vnt. - 4% nuolaidą, įveskite kiekį kurį norite pirkti ir Jums atspausdinsime kainą");
            Console.WriteLine($"Perkamų žvakių kiekis: {zkiekis}.");
            Console.WriteLine($"Kaina:{viso}EUR");

        }
    }
}
