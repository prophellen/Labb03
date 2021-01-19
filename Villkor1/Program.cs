using System;

namespace Villkor1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Är MFF Sveriges bästa lag?");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "ja")
                Console.WriteLine("Helt rätt!");
        }
    }
}
