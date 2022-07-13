using System;
using System.Collections.Generic;
using static System.Math;

namespace Arrays
{
    class Program
    {
        static void ElemInArray()
        {
            Console.Write("The Length of array (input number) = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i} = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }
        static void ReverseArray()
        {
            Console.Write("The Length of array (input number) = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i} = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] arrRev = new int[n];
            int j = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                if (j < n)
                {
                    arrRev[j] = arr[i];
                }
                else
                {
                    break;
                }
                j++;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("_______________________________");
            Console.WriteLine("Reverse");
            foreach (var item in arrRev)
            {
                Console.Write(item + " ");
            }


        }
        static void SumOfElements()
        {
            Console.Write("The Length of array (input number) = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i} = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            Console.WriteLine($"Sum of Elements = {sum}");
        }
        static void DublicatElements()
        {
            Console.Write("The Length of array (input number) = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i} = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = 0;
            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        temp++;
                        if (temp > max)
                        {

                            max = temp;
                        }
                    }
                }
                temp = 0;
            }
            Console.WriteLine(max);

        }
        static void ArithmeticAverage()
        {

            Console.Write("The Length of array (input number) = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i} = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int count = 0;
            int sum = 0;
            foreach (var item in arr)
            {
                if (item >0)
                {
                    sum += item;
                    count++;
                }
            }
            double average = (double)sum / count;
            Console.WriteLine($"The arithmetic avarage = {average}");
        }
        static void MeanSquare()
        {
            Console.Write("The Length of array (input number) = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i} = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int count = 0;
            int sum = 0;
            foreach (var item in arr)
            {
                if (item > 0)
                {
                    sum += item*item;
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("There is no positive numbers!");
            }
            else
            {

            double square = Sqrt((double)sum / count);
            Console.WriteLine($"The mean square = {square}");
            }

        }
        static void NegArithmeticAverage()
        {
            Console.Write("The Length of array (input number) = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i} = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int count = 0;
            int sum = 0;
            foreach (var item in arr)
            {
                if (item < 0)
                {
                    sum += item;
                    count++;
                }
            }
            double average = (double)sum / count;
            Console.WriteLine($"The arithmetic avarage = {average}");
        

    }
        static void RangeSum()
        {
            Console.Write("The Length of array (input number) = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i} = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            Console.WriteLine($"Input Range 0-{n}");
            int rangeLeft = Convert.ToInt32(Console.ReadLine());
            int rangeRight = Convert.ToInt32(Console.ReadLine());
            for (int i = rangeLeft; i <= rangeRight; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine($"In [{rangeLeft},{rangeRight}] element sum = {sum}");

        }
        static void Main(string[] args)
        {
            // ElemInArray();//Write a program in C# Sharp to store elements in an array and print it.
            //ReverseArray();//Write a program in C# Sharp to read n number of values in an array and display it in reverse order
            //SumOfElements();//Write a program in C# Sharp to find the sum of all elements of the array.
            //DublicatElements();//Write a program in C# to count a total number of duplicate elements in an array.
            //ArithmeticAverage();//Positive values arithmetic average
            //MeanSquare();//Positive values mean square
            //NegArithmeticAverage();//Negativ values arithmetic average
            RangeSum();//Sum the numbers in the range

        }
    }
}
