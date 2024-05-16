using System;

namespace AntraUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Sveiki, įveskite du skaičius kuriuos norite susumuoti, sužinoti jų skirtumą, sandaugą ir dalmenį ");
            Console.WriteLine("Įveskite pirmąjį skaičių:");
            double.TryParse(Console.ReadLine(), out double skaicius1);

            Console.WriteLine("Įveskite antrąjį skaičių:");
            double.TryParse(Console.ReadLine(), out double skaicius2);

            double suma = skaicius1 + skaicius2;
            double skirtumas = skaicius1 - skaicius2;
            double sandauga = skaicius1 * skaicius2;
            double dalmuo = skaicius1 / skaicius2;

            Console.WriteLine($"Jūsų rezultatai:\nSuma:{suma}\nSkirtumas:{skirtumas}\nSandauga:{sandauga}\nDalmuo:{dalmuo}");

       
            //Pagridinis kodas

        }
    }
}