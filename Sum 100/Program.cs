using System;

namespace Sum_100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Professor!");

            int i = 1;
            int sum = 0;

            while (i <= 100)
            {
                sum = sum + i;
                i++;
            }

            Console.WriteLine("Suma primelor 100 numere naturale > 0 este " + sum);
                
        }
    }
}
