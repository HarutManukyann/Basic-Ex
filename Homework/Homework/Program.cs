using System;

namespace Homework
{
    class Program
    {
        static void TheBiggest()
        {
            Console.WriteLine("Input Numbers any you want:");
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine($"The biggest number is a = {a}");
                }
                else
                {
                    Console.WriteLine($"The biggest number is c = {c}");
                }
            }
            else if (b > c)
            {
                Console.WriteLine($"The biggest number is b = {b}");
            }
            else
            {
                Console.WriteLine($"The biggest number is c = {c}");
            }
        }
        static void TheSmallest()
        {
            Console.WriteLine("Input Numbers any you want:");
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            int c = Convert.ToInt32(Console.ReadLine());


            if (a < b)
            {
                if (a < c)
                {
                    Console.WriteLine($"The smallest number is a = {a}");
                }
                else
                {
                    Console.WriteLine($"The smallest number is c = {c}");
                }
            }
            else if (b < c)
            {
                Console.WriteLine($"The smallest number is b = {b}");
            }
            else
            {
                Console.WriteLine($"The smallest number is c = {c}");
            }
        }
        static void EqualOne()
        {
            Console.WriteLine("Input Numbers any you want:");
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("________________________________");

            if (a == 1 || b == 1 || c == 1)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
        static void EqualTwo()
        {
            Console.WriteLine("Input Numbers any you want:");
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("________________________________");

            if (a == 2)
            {
                if (b == 2 || c == 2)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
            else if (b == 2)
            {
                if (c == 2)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
            else
            {
                Console.WriteLine(false);
            }

        }
        static void Triangle()
        {
            Console.WriteLine("Input Numbers any you want:");
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("________________________________");

            if (a + b > c)
            {
                if (a + c > b)
                {
                    if (b + c > a)
                    {
                        Console.WriteLine("y = 1");
                    }
                    else
                    {
                        Console.WriteLine("y = 2");
                    }
                }
                else
                {
                    Console.WriteLine("y = 2");
                }
            }
            else
            {
                Console.WriteLine("y = 2");
            }

        }
        static void EvenNum()
        {
            Console.WriteLine("Input Numbers any you want:");
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("________________________________");

            if (a % 2 == 0 || b % 2 == 0 || c % 2 == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("2");
            }

        }
        static void ArithmeticProg()
        {
            Console.WriteLine("Input Numbers any you want:");
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("________________________________");

            if (a - b == b - c || a - c == c - b || b - a == a - c ||
                b - c == c - a || c - b == b - a || c - a == a - b)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
        static void GeometricProg()
        {
            Console.WriteLine("Input Numbers any you want:");
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("________________________________");

            //_________________________EMPTY
        } //?

        static void AcsendingOrder()
        {
            Console.WriteLine("Input Numbers any you want:");
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("________________________________");

            if (a < b && a < c)
            {
                Console.WriteLine(a);
                if (b < c)
                {
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(c);
                    Console.WriteLine(b);

                }
            }
            else if (b < a && b < c)
            {
                Console.WriteLine(b);
                if (a < c)
                {
                    Console.WriteLine(a);
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                }
            }
            else
            {
                Console.WriteLine(c);
                if (b < a)
                {
                    Console.WriteLine(b);
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                }
            }

        }
        static void DecreasingOrder()
        {
            Console.WriteLine("Input Numbers any you want:");
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("________________________________");

            if (a > b && a > c)
            {
                Console.WriteLine(a);
                if (b > c)
                {
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(c);
                    Console.WriteLine(b);

                }
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b);
                if (a > c)
                {
                    Console.WriteLine(a);
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                }
            }
            else
            {
                Console.WriteLine(c);
                if (b > a)
                {
                    Console.WriteLine(b);
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                }
            }

        }
        static void Main(string[] args)
        {
            //Given 3 different numbers a,b,c 
            //TheBiggest(); // Find the biggest of 3 numbers
            //TheSmallest(); // Find the smallest of 3 numbers
            //EqualOne(); // If one of the given numbers  is equal 1. Output TRUE otherwise FALSE
            //EqualTwo(); // If two of the given numbers is equal 2. Output TRUE otherwise FALSE
            //Triangle();  // Is it possible to get a triangle. If yes output 'y=1', else 'y=2'
            //EvenNum();  //If one of the given numbers  is even. Output 1 otherwise 2
            //ArithmeticProg(); // If these numbers form an arithmetic progression. Output TRUE otherwise FALSE
            //?GeometricProg(); // If these numbers form an geometric progression. Output TRUE otherwise FALSE
            //AcsendingOrder(); // Output sorted in acsending order <
            //DecreasingOrder(); // Output sorted in decreasing order >

        }
    }
}
