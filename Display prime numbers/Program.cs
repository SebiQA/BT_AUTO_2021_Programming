using System;

namespace Display_prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Professor!");

            int limita = 40;
            int no;
            int i;
            int count;

            for (no = 2; no <= limita; no++)
            {
                count = 0;
                for (i = 2; i <= no; i++)
                {
                    if (no % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    Console.WriteLine(no);
                }
            }

        }
    }
}
