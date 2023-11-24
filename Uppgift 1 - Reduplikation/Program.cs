using System;

namespace Uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilket ord?");
            string ord = Console.ReadLine();
            Console.WriteLine("Hur många upprepningar?");
            int antal = int.Parse(Console.ReadLine());
            for (int i = 0; i < antal; i++)
            {
                Console.Write(ord);
            }

        }

    }
}
    