using System;

namespace Homework
{
    class Program
    { 

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Professor!");


            if (args.Length == 3)
            {

                float a = float.Parse(args[0]);

                float b = float.Parse(args[2]);

                string op = args[1];

                float result;



                switch (op)
                {
                    case "*":
                        {
                            result = a * b;
                            Console.WriteLine("Result is " + result);
                            break;
                        }

                    case "+":
                        {
                            result = a + b;
                            Console.WriteLine("Result is " + result);
                            break;
                        }

                    case "-":
                        {
                            result = a - b;
                            Console.WriteLine("Result is " + result);
                            break;
                        }

                    case "/":
                        {
                            result = a / b;
                            Console.WriteLine("Result is " + result);
                            break;
                        }

                    case "%":
                        {
                            result = a % b;
                            Console.WriteLine("Result is " + result);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid inputs");
                            break;
                        }
                }
                        
            }
            else
            {

                Console.WriteLine("3 args are needed!");

            }

        }
    }
}

