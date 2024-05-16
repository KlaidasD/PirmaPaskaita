using System;

namespace TreciaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Sveiki, įveskite laipsnius Farenheito skalėje ją konvertuosim į Celsijaus skalę");
            double.TryParse(Console.ReadLine(), out double fahr);
            double celsius = (fahr - 32) / 1.8;
            Console.WriteLine($"Jūsų temperatūra celsijaus skalėje:{celsius}");
      


            //Pagridinis kodas

        }
    }
}