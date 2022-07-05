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
        static void Main(string[] args)
        {
            //Given 3 different numbers a,b,c 
            TheBiggest(); // Find the biggest of 3 numbers
            TheSmallest(); // Find the smallest of 3 numbers
        }
    }
}
