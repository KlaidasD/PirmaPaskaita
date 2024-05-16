using System;
using System.Linq;

namespace antraPaskaita;

/*Naudokite funkcija new Random(). Sugeneruokite 6 kintamuosius su atsitiktinem reikšmėm nuo 1000 iki 9999. 
 * Atspausdinkite reikšmes viename stringe, išrūšiuotas nuo didžiausios iki mažiausios, atskirtas tarpais. Naudoti ciklų ir masyvų NEGALIMA. */

public class Program
{
    public static void Main(string[] args)
    {
        Random rnd = new Random();

        int a = rnd.Next(1000, 10000);
        int b = rnd.Next(1000, 10000);
        int c = rnd.Next(1000, 10000);
        int d = rnd.Next(1000, 10000);
        int e = rnd.Next(1000, 10000);
        int f = rnd.Next(1000, 10000);

        var paeiliui = new[] { a, b, c, d, e, f }.OrderByDescending(x => x);

        string rez = string.Join(" ", paeiliui);


        Console.WriteLine($"Sugeneruoti 6 skaiciai :{a} {b} {c} {d} {e} {f} .");
        Console.WriteLine($"Sugeneruoti 6 skaiciai paeiliui: {rez}");




    }
}