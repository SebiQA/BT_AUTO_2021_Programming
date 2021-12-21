using System;

namespace BT_AUTO_2021_Programming
{
    class Program
    {
       static void Main(string[] args)
       {
            //Course01(args);
            //Course02(args);
            //Course03(args);
            //Course04();
            Course05();
       }

        static void Course05()
        {
            DrawShapeOutline(5);
            DrawShapeOutline(10, 5);
            DrawShapeCorners(6);
            DrawFullShape(7);

            Circle c = new Circle(4);
            Object O = new Object();
            c.Draw();
            Triangle t1 = new Triangle(5, 7, 9);
            t1.Draw();
            Square s1 = new Square(5);
            Rectangle r1 = new Rectangle(2, 7);
            Console.WriteLine(s1.GetArea());
            Console.WriteLine(r1.GetArea());
            Console.WriteLine(c.ToString());
            Console.WriteLine(s1.ToString());
            Console.WriteLine(r1.ToString());
            Console.WriteLine(t1.ToString());

            Teacher teacher1 = new Teacher("Programing", "UBB", 2000, "Gigel Programatoru", 'm');
            teacher1.PrintTeacher();

            Student student1 = new Student("AN 1", true, true, "Seb F", 'm');
            student1.PrintStudent();


        }
       static void Course01(string[] args)
        {
            
                const int MAX_SIZE = 100;
                const double PI = 3.14;
                const int MAX = 5;

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

                int number = 4;
                Console.WriteLine("tested number is" + number);

                if (number >= 0)
                {
                    Console.WriteLine("No is positive");
                }
                else
                {
                    Console.WriteLine("No is negative");
                }

                if (number % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }

                if (number <= 40 && number >= 0)
                {
                    if (number <= 20)
                    {
                        Console.WriteLine("Student failed");
                    }
                    else
                    {
                        Console.WriteLine("Student passed");
                    }

                }
                else
                {
                    Console.WriteLine("invalid number");
                }

                // one line if / else
                String message = (number % 2 == 0) ? "even" : "odd";
                Console.WriteLine(message);

                if (number == 1)
                {
                    Console.WriteLine("Monday");
                }

                if (number == 2)
                {
                    Console.WriteLine("Tuesday");
                }

                if (number == 3)
                {
                    Console.WriteLine("Wednesday");
                }

                if (number == 4)
                {
                    Console.WriteLine("Thursday");
                }

                if (number == 5)
                {
                    Console.WriteLine("Friday");
                }

                if (number == 6)
                {
                    Console.WriteLine("Saturday");
                }

                if (number == 7)
                {
                    Console.WriteLine("Sunday");
                }

                if (number < 1 || number > 7)
                {
                    Console.WriteLine("Not a valid date");
                }

                switch (number)
                {
                    case 1:
                        {
                            Console.WriteLine("Monday");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Tuesday");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Wednesday");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Thursday");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Friday");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Saturday");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Sunday");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Not a valid date");
                            break;
                        }
                }

                int counter = 0;
                while (counter <= MAX)
                {
                    Console.WriteLine("current number is:" + counter);
                    counter++;
                }

                counter = 0;
                do
                {
                    Console.WriteLine("current number is:" + counter);
                    counter++;
                }
                while (counter <= MAX);

                for (counter = 0; counter <= MAX; counter++)
                {
                    //Console.WriteLine("Current number is" + counter); <=>
                    Console.WriteLine("Current number is: {0}", counter);
                }

                foreach (string argument in args)
                {
                    Console.WriteLine("the argument is: {0}", argument);
                }

                int year = 1900;
                int febDays = 28;

                /*if (year % 4 == 0)
                {
                    if (year % 100 == 0 && year % 400 != 0)
                    {
                        febDays = 29;
                    }

                    if (year % 100 !=0)
                    {
                        febDays = 29;
                    }

                }*/
                if (year < 1900 || year > 2016)
                {
                    Console.WriteLine("year is out of boundaries");
                }

                if ((year % 4 == 0 && year % 100 == 0 && year % 400 != 0) || (year % 4 == 0 && year % 100 != 0))
                {
                    febDays = 29;
                }
                Console.WriteLine("February has {0} days", febDays);

            
        }

       static void Course02(string[] args)
       {
            Circle c1 = new Circle();
            Circle c2; //will be null
            c1.SetRadius(10);
            //double area = c1.GetArea();
            //Console.WriteLine(c1.GetArea());
            c1.PrintCircle();

            Circle c3 = new Circle();
            
            c3.SetRadius(5);
            c3.PrintCircle();

            foreach (string p in args)
            {
                Circle c = new Circle();
                c.SetRadius(double.Parse(p));
                Square s = new Square();
                s.SetSide(Double.Parse(p));

                Rectangle r = new Rectangle();
                r.SetSize(double.Parse(p), double.Parse(p));

                c.PrintCircle();
                s.PrintSquare();
                r.PrintRectangle();

            }

            Person p1 = new Person();
            p1.SetName("Sebi");
            p1.SetSex('m');
            p1.Eat();
            p1.Run();
            p1.PrintPerson();

            Rectangle r1 = new Rectangle();
            r1.SetSize(2, 3);
            r1.PrintRectangle();

       }

       static void Course03(string[] args)
       {
            //ComputeConversion(args);
            CurrencyCalculator(156, "USD", 4.3734);
            Shape s = GetShape(12, 34, 12.4, 'a', "17d");
            //Console.WriteLine(ConcatenateString(args));
            GuessNumber(678);
       }
       static void Course04()


       {
            DrawFullShape(5, 3);
            Console.WriteLine();
            DrawShapeOutline(8, 8 );
            Console.WriteLine();
            DrawShapeCorners(5, 5);

            Circle c1 = new Circle();   //instantiate c1 with default (no parameters) constructor
            Circle c2 = new Circle(10); //instantiate c2 with parameter constructor
            c1.PrintCircle();
            c2.PrintCircle();

            Person p1 = new Person();
            Person p2 = new Person("Seb", 'm', new string[] { "Dac" }, false, new DateTime());
            p1.PrintPerson();
            p2.PrintPerson();

            Rectangle r1 = new Rectangle(2, 7);
            r1.PrintRectangle();

            Square s1 = new Square(4);
            s1.PrintSquare();

            Struct_example se = new Struct_example();
            Struct_example.MyStruct myStruct = new Struct_example.MyStruct();
            myStruct.Assign(10, "abc");
            Console.WriteLine(myStruct.ComputeSum());

            Struct_example.Rectangle3D r2 = new Struct_example.Rectangle3D();
            r2.Assign(2, 5, 7);
            Console.WriteLine(r2.GetVolume());
       }

        public static void DrawShapeCorners(int width, int heigth)
        {

            for (int j = 0; j < heigth; j++)
            {
                for (int i = 0; i < width; i++) // this will print a single line with * counting width
                {
                    if(j==0 || j==heigth-1) 
                    {
                        if (i==0 || i==width-1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void DrawShapeOutline(int width, int heigth)
        {
            for (int j = 0; j < heigth; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    if (j == 0 || j == heigth - 1)
                    {
                        Console.Write("*");
                    }

                    else
                    {
                        if ( i == 0 || i == width - 1)
                        {
                            Console.Write("*");
                        }

                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    
                }
                Console.WriteLine();
            }

        }

        public static void DrawShapeOutline(int l)
        {
            DrawShapeOutline(l, l);
        }

        public static void DrawShapeCorners(int l)
        {
            DrawShapeCorners(l, l);
        }

        public static void DrawFullShape(int l)
        {
            DrawFullShape(l, l);
        }

        public static void DrawFullShape(int width, int heigth)
        {

            for (int j = 0; j < heigth; j++)
            {
                for (int i = 0; i < width; i++) // this will print a single line with * counting width
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static int TestValue(int testVal, int target)
        {

            if (testVal < target)
            {
                Console.WriteLine("No to be guessed is higher");
                return -1;
            }
            if (testVal > target)
            {
                Console.WriteLine("No to be guessed is lower");
                return 1;
            }
            Console.WriteLine("Bazinga");
            return 0;
        }

        static void GuessNumber(int n)
        {
            int currentNumber = 0;
            do
            {
                currentNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("No chosen is {0}", currentNumber);
            }
            while (TestValue(currentNumber, n) != 0);
        }

        static bool IssOddNumber(int number)
       {
            
            {
                return number % 2 != 0;
            }
       }

        static void ComputeConversion(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("The app reveives only 3 parameters: amount, currency, exachange rate");
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", args[0], args[1], args[2]);
                /* double amount = Double.Parse(args[0]);
                 string currency = args[1];
                 double conversionRate = Double.Parse(args[2]);
                 Console.WriteLine("By converting {0} {1} into RON we obtain {2} RON", amount, currency, amount * conversionRate); */
                CurrencyCalculator(Double.Parse(args[0]), args[1], Double.Parse(args[2]));
                CurrencyCalculator(156, "USD", 4.3734);

            }
        }

        static void CurrencyCalculator(double amount, string currency, double conversionRate)
        { 
            Console.WriteLine("By converting {0} {1} into RON we obtain {2} RON", amount, currency, amount * conversionRate);
        }

        static Shape GetShape(int x, int y, double a, char t, string s)
        {
            Console.WriteLine(x);
            return new Shape();
        }
        static string ConcatenateString(string[] args)
        {
            string returnString = "";
            foreach (string s in args)
            {
                returnString += s; // returnString = returnString + s;

            }
            return returnString;
        }


    }
}
 