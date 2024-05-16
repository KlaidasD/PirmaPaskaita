using System;
using System.Transactions;

namespace randomPamoka
{
    public class Program

    //Sukurkite du kintamuosius ir naudodamiesi funkcija new Random() jiems priskirkite atsitiktines reikšmes nuo 0 iki 4.
    //Didesnę reikšmę padalinkite iš mažesnės. Atspausdinkite rezultatą jį suapvalinę iki 2 skaičių po kablelio.
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();

            int skaicius1 = rnd.Next(0, 4);
            int skaicius2 = rnd.Next(0, 4);

            double result;
            if (skaicius1 == 0 || skaicius2 == 0)
            {
                Console.WriteLine("Dalyba is nulio negalima");
                return;
            }

            if (skaicius1 > skaicius2) 
            {
               result = skaicius1 / skaicius2;
            }
            else
            {
               result = skaicius2 / skaicius1;
            }
            Console.WriteLine(Math.Round(result, 2));
          

        }
    }
}