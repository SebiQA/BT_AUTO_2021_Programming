using System;

namespace BT_AUTO_2021_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_SIZE = 100;
            const double PI = 3.14;
        
            Console.WriteLine("Hello World!");
            Console.WriteLine("Ana are pere nu si mere");
            Console.WriteLine(5 + 2);
            Console.WriteLine("5+2");

            int numberOfstudents = 5;
            int count;
            int a, b;
            a = numberOfstudents + 1;
            a = a + numberOfstudents;

            float numberFloat = 5.6F;
            double numberDouble = 5.6;

            float f = (float)numberDouble;
            int numberInt = (int)f;
            long l = numberOfstudents;

            Console.WriteLine(typeof(int).IsPrimitive);

            bool myBoolean = false;

            char ch = '1'; // '1' != 1

            string myString = "Ana are merisoare";
            string result = a + "si struguri";
            Console.WriteLine(result);

            DateTime dataCurenta = new DateTime(2021, 12, 8);
            Console.WriteLine(dataCurenta);

            Console.WriteLine(numberFloat * a);
            Console.WriteLine(numberDouble / a);
            Console.WriteLine(5 % 6);

            int x = 2;
            x += 5; // x=x+5
            // x++ <=> x=x+1
            // ++x <=> x=x+1
            Console.WriteLine(++x);
            Console.WriteLine((x < a) ^ (x == a));

        }
    }
}
 