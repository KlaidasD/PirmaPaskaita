using System;
using System.Transactions;

namespace PirmaPaskaita
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random()
                int randomSkaicius = rand.Next(1, 10);

            Console.WriteLine("Iveskite skaiciu: ");
            int skaicius = int.Parse(Console.ReadLine());
            switch(skaicius)
            {
                case > 2:
                    Console.WriteLine("Skaicius yra didesnis, nei 2");
                    break;
                case < 2:
                    Console.WriteLine("Skaicius yra mazesnis, nei 2");
                    break;
                default:
                    Console.WriteLine("Nei 0, nei 10");
                    break;


            }
        }
    }
}