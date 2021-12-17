using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Professor!");


            int p, r, sum = 0, inv;
            Console.Write("The number to be checked as palindrome is: ");
            p = int.Parse(Console.ReadLine());
            inv = p;
            while (p > 0)
            {
                r = p % 10;
                sum = (sum * 10) + r;
                p = p / 10;
            }
            if (inv == sum)
            {
                Console.Write("Number is palindrome.");
            }
            else
            {
                Console.Write("Number is not palindrome");
            }
        }
    }
}
