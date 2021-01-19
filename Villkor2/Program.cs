using System;

namespace Villkor2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temps = new int[2];

            Console.Write("Fyll i temperaturen i Svedala: ");
            temps[0] = int.Parse(Console.ReadLine());

            Console.Write("Fyll i temperaturen i Jukkasjärvi: ");
            temps[1] = int.Parse(Console.ReadLine());

            if (temps[0] < temps[1])
            {
                Console.WriteLine("Det är kallast i Svedala");
            }
            else if (temps[1] < temps[0])
            {
                Console.WriteLine("Det är kallast i Jukkasjärvi");
            }
            else
            {
                Console.WriteLine("Det är lika temperatur i Svedala och Jukkasjärvi");
            }



        }
    }
}
