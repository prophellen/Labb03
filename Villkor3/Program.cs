using System;

namespace Villkor3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temps = new double[3];

            Console.Write("Fyll i temperaturen i Svedala: ");
            temps[0] = double.Parse(Console.ReadLine());

            Console.Write("Fyll i temperaturen i Jukkasjärvi: ");
            temps[1] = double.Parse(Console.ReadLine());

            Console.Write("Fyll i temperaturen i Visby: ");
            temps[2] = double.Parse(Console.ReadLine());

            double medelvärde = Math.Round((temps[0] + temps[1] + temps[2]) / 3, 1);

            if (temps[0] > temps[1] && temps[0] > temps[2])            
                Console.WriteLine($"Det är varmast i Svedala. Medeltemperaturen är {medelvärde} grader.");            
            else if (temps[1] > temps[0] && temps[1] > temps[2])            
                Console.WriteLine($"Det är varmast i Jukkasjärvi. Medeltemperaturen är {medelvärde} grader.");            
            else if (temps[2] > temps[0] && temps[2] > temps[1])            
                Console.WriteLine($"Det är varmast i Visby. Medeltemperaturen är {medelvärde} grader.");            
            else if (temps[0] == temps[1] && temps[0] == temps[2])            
                Console.WriteLine($"Det är lika varmt i alla städer. Medeltemperaturen är {medelvärde} grader.");            
            else if (temps[0] == temps[1] && temps[1] > temps[2])            
                Console.WriteLine($"Det är varmast i Svedala och Jukkasjärvi. Medeltemperaturen är {medelvärde} grader.");            
            else if (temps[0] == temps[2] && temps[0] > temps[1])            
                Console.WriteLine($"Det är varmast i Svedala och Visby. Medeltemperaturen är {medelvärde} grader.");            
            else if (temps[2] == temps[1] && temps[2] > temps[0])            
                Console.WriteLine($"Det är varmast i Jukkasjärvi och Visby. Medeltemperaturen är {medelvärde} grader.");
            

        }
    }
}
