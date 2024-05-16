using System;
using System.Transactions;

namespace apskaiciuoti
{
    public class Program
    {
        // Sukurkite keturis kintamuosius ir new Random() funkcija sugeneruokite jiems
        // reikšmes nuo 0 iki 2. Suskaičiuokite kiek yra nulių, vienetų ir dvejetų. (sprendimui masyvo nenaudoti).
        public static void Main(string[] args)
        {
            Random rnd = new Random();

            int a = rnd.Next(0, 3);
            int b = rnd.Next(0, 3);
            int c = rnd.Next(0, 3);
            int d = rnd.Next(0, 3);

            int nuliai = 0;
            int vienetai = 0;
            int dvejetai = 0;

            if (a == 0) nuliai++;
            else if (a == 1) vienetai++;
            else if (a == 2) dvejetai++;

            if (b == 0) nuliai++;
            else if (b == 1) vienetai++;
            else if (b == 2) dvejetai++;

            if (c == 0) nuliai++;
            else if (c == 1) vienetai++;
            else if (c == 2) dvejetai++;

            if (d == 0) nuliai++;
            else if (d == 1) vienetai++;
            else if (d == 2) dvejetai++;

            Console.WriteLine($"Sugeneravus 4 atsitiktinius skaicius nuo 0 iki 2 ir suskaiciavus kiek ju yra, rezultatas:{a},{b},{c},{d}\nNuliai:{nuliai}\nVienetai:{vienetai}\nDvejetai:{dvejetai}");


        }
    }
}
