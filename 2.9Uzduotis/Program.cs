using System;
using System.Transactions;

namespace laikrodis
{
    public class Program
    {
        /* Padarykite skaitmeninį laikrodį, rodantį valandas, minutes ir sekundes. Valandom, minutėm ir sekundėm sugeneruoti panaudokite funkciją new Random().
         * Sugeneruokite skaičių nuo 0 iki 300. Tai papildomos sekundės. Skaičių pridėkite prie jau sugeneruoto laiko.
         * Atspausdinkite laikrodį prieš ir po sekundžių pridėjimo ir pridedamų sekundžių skaičių.*/
        public static void Main(string[] args)
        {
          Random rnd = new Random();

            int val = rnd.Next(0, 24);
            int min = rnd.Next(0, 60);
            int sek = rnd.Next(0, 60);
            int psek = rnd.Next(0, 301);


            Console.WriteLine($"Dabartinis laikas:{val}:{min}:{sek}");
            Console.WriteLine($"Pridedamos papildomos {psek} sekundės.");

            sek += psek;

            if (sek >= 60)
            {
                sek -= 60;
                min++;

                if (min >= 60)
                {
                    min -= 60;
                    val++;

                    if (val >= 24)
                    {
                        val -= 24;

                    }    
                }
            }

            Console.WriteLine($"Dabartinis laikas:{val}:{min}:{sek}");
        }
    }
}
