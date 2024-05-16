using System;
using System.Transactions;

namespace kintamujuUzduotis
{
    public class Program

        //Sukurkite 4 kintamuosius, kurie saugotų jūsų vardą, pavardę, gimimo metus ir šiuos metus (nebūtinai tikrus).
        //Parašykite kodą, kuris pagal gimimo metus paskaičiuotų jūsų amžių ir naudodamas vardo ir pavardės kintamuosius atspausdintų tokį sakinį :
	    //"Aš esu Vardenis Pavardenis. Man yra XX metai(ų)".
    {
        public static void Main(string[] args)
        {
            string name = "Klaidas";
            string surname = "Daunoras";
            int dob = 1997;
            int year = 2024;
            int age = year - dob;

            Console.WriteLine($"Aš esu {name} {surname}, man yra {age} metai(ų).");
                







        }
    }
}