using System;
using System.Transactions;

namespace randomPamoka
{
    public class Program

    //Naudokite funkcija new Random(). Sukurkite tris kintamuosius ir naudodamiesi funkcija new Random()
    //jiems priskirkite atsitiktines reikšmes nuo 0 iki 25. Raskite ir
    //atspausdinkite kintąmąjį turintį vidurinę reikšmę.
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();

            int skaicius1 = rnd.Next(0, 25);
            int skaicius2 = rnd.Next(0, 25);
            int skaicius3 = rnd.Next(0, 25);

            double vidurineR = (skaicius1 + skaicius2 + skaicius3) / 3;


                Console.WriteLine($"Vidurine reiksme: siu atsitiktinu skaiciu : {skaicius1}, {skaicius2} ir {skaicius3} yra :{vidurineR}");

        }
    }
}