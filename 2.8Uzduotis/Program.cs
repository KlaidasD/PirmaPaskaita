using System;
using System.Transactions;

namespace vidurkis
{
    public class Program
    {
        /* Naudokite funkcija new Random(). Sukurkite tris kintamuosius su atsitiktinėm reikšmėm nuo 0 iki 100.
        Paskaičiuokite jų aritmetinį vidurkį. Ir aritmetinį vidurkį atmetus tas reikšmes, kurios yra mažesnės nei 10 arba didesnės nei 90.
        Abu vidurkius atspausdinkite. Rezultatus apvalinkite iki sveiko skaičiaus.*/
        public static void Main(string[] args)
        {
            Random rnd = new Random();

            int a = rnd.Next(0, 100);
            int b = rnd.Next(0, 100);
            int c = rnd.Next(0, 100);
            double vidurkis = a + b + c / 3;

            Console.WriteLine($"Gauti skaičiai: {a}, {b}, {c}.");
            Console.WriteLine($"Gautų skaičių vidurkis:{vidurkis}");

            if (a < 10 || a > 90)
                a = 0;
            if (b < 10 || b > 90)
                b = 0;
            if (c < 10 || c > 90)
                c = 0;

            double vidurkisbe = a + b + c / 3;

            Console.WriteLine($"Gautų skaičių vidurkis be kintamuojų kurie mažesni, nei 10 ar didesni, nei 90 : {vidurkisbe}." );

        }
    }
}
