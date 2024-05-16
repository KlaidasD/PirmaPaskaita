using System;

namespace TreciaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Sveiki, įveskite savo gimimo datą, išvesime jūsų amžių");
            Console.WriteLine("Įveskite gimimo datą:");
            double gdata;
            double.TryParse(Console.ReadLine(), out gdata);

            Console.WriteLine($"Jūsų gimimo metai:{gdata}");
            double amzius = 2024 - gdata;
            Console.WriteLine($"Jūsų amžius:{ amzius}");
            
            
            //Pagridinis kodas

        }
    }
}