using System;
namespace Uppgift_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett lön för en anställd på ditt företag");
            string anst1 = Console.ReadLine();
            int lön1 = int.Parse(anst1);

            Console.WriteLine("Okej, kanonbra, var snäll och skriv in lönet för ytterlgiare en anställd hos ditt företag");
            string anst2 = Console.ReadLine();
            int lön2 = int.Parse(anst2);

            Console.WriteLine("Skriv in lönet för den sista anställd");
            string anst3 = Console.ReadLine();
            int lön3 = int.Parse(anst3);

            Console.WriteLine("Medellönen för dina anställda på ditt företag är: " + (lön1 + lön2 + lön3) / 3 + " kronor.");

        }
    }
}