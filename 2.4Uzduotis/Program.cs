using System;
using System.Transactions;

namespace trikampis
{
    public class Program
    {
        // Įvedami skaičiai - a, b, c –kraštinių ilgiai,
        // trys kintamieji (naudojame int) (naudokite new Random() funkcija nuo 1 iki 10).
        // Parašykite C# programą, kuri nustatytų, ar galima sudaryti trikampį ir atsakymą atspausdintų.
        public static void Main(string[] args)
        {
            Random rnd = new Random();

            int a = rnd.Next(1, 10);
            int b = rnd.Next(1, 10);
            int c = rnd.Next(1, 10);

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine($"Galimas trikampis iš šių kraštinių: a = {a}, b = {b}, ir c = {c}");
            }
            else
            {
                Console.WriteLine($"Trikampio iš šių kraštinių a = {a}, b = {b}, ir c = {c} sudaryti negalima");
            }
        }
    }
}
