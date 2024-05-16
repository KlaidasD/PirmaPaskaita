using System;
using System.Transactions;

namespace TRYSRANDOM
{
    public class Program
    {
        // Naudokite funkcija new Random(). Sukurkite ir atspausdinkite 3 skaičius nuo -10 iki 10.
        // Skaičiai mažesni už 0 turi būti  laužtiniuose skliaustuose [], 0 -  (), didesni už 0 {}.
        public static void Main(string[] args)
        {
            Random rnd = new Random();

            int a = rnd.Next(-10, 10);
            int b = rnd.Next(-10, 10);
            int c = rnd.Next(-10, 10);

            string aa, bb, cc; 

            if (a < 0)
            {
                aa = $"[{a}]";
            }
            else if (a == 0)
            {
                aa = $"({a})";
            }

            else 
            {
                aa = $"{{{a}}}";
            }
            if (b < 0)
            {
                bb = $"[{b}]";
            }
            else if (b == 0)
            {
                bb = $"({b})";
            }
            else
            {
                bb = $"{{{b}}}";
            }

            if (c < 0)
            {
                cc = $"[{c}]";
            }
            else if (c == 0)
            {
                cc = $"({c})";
            }
            else
            {
                cc = $"{{{c}}}";
            }



            Console.WriteLine($"Trys atsitiktiniai skaiciai : {aa}, {bb}, {cc} .");


        }
    }
}
