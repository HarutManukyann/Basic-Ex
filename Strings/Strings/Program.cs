using System;

namespace Strings
{
    class Program
    {
        public struct Time
        {
            public int Days, Months, Year;
            public Time(int day, int moths, int year)
            {
                Days = day;
                Months = moths;
                Year = year;
            }
        }
        public class Timer
        {
            private int Count;
            public Timer(int count)
            {
                Count = count;
            }
        }
        static int Calc(char ch, int elem1, int elem2)
        {
            int result = 0;

            switch (ch)
            {
                case '+':
                    result = elem1 + elem2;

                    break;
                case '-':
                    result = elem1 - elem2;
                    break;
                case '/':
                    result = elem1 / elem2;
                    break;
                case '*':
                    result = elem1 * elem2;
                    break;
                default:
                    break;
            }
            return result;

        }
        public static int Factorial(int i)
        {
            int mult;
            if (i == 0)
                return 1;

            mult = i * Factorial(i - 1);
            return mult;
        }

        public static int Sumari(int num)
        {
            int result = 0;
            for (int i = 0; i <= num; i++)
            {
                result += i;
            }
            return result;

        }
        public static int Sum(int num)
        {
            int result=0;
            if (num == 0)
            {
                return result;
            }
            else
            {
                result = num + Sum(num - 1);
                return result;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(100));
            Console.WriteLine(Sumari(100));
            //Console.WriteLine(Factorial(6));
            //Time time;
            //time.Days = 3;
            //int elem1=0;
            //int elem2=0;
            //char ch='+';

            //string str = "40-15=";
            //int temp = 0;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] >= 48 && str[i] <= 57 && str[i + 1] >= 48 && str[i + 1] <= 57)
            //    {

            //        temp = Convert.ToInt32(str.Substring(i, 2));
            //        if (i < 2)
            //        {
            //            elem1 = temp;

            //            Console.WriteLine(elem1);
            //        }
            //        else
            //        {
            //            elem2 = temp;
            //            Console.WriteLine(elem2);
            //        }
            //        temp = 0;

            //    }
            //    else if (str[i] == 42 || str[i] == 43 || str[i] == 45 || str[i] == 47)
            //    {
            //        ch = str[i];
            //        Console.WriteLine(ch);
            //    }
            //}
            //Console.WriteLine("_____________________________");
            //Console.WriteLine( "Answer" );
            //Console.WriteLine("_____________________________");
            //Console.WriteLine(   Calc(ch, elem1, elem2));
            ////Console.WriteLine(ch);




            #region String max symbol
            //Console.Write("Input string: ");
            //string str = Console.ReadLine();
            //int max = 0;
            //char sym = ' ';
            //for (int i = 0; i < str.Length; i++)
            //{
            //    int count = 0;
            //    for (int j = 0; j < str.Length; j++)
            //    {
            //        if (str[i] == str[j])
            //        {
            //            count++;
            //        }

            //    }
            //    if (count > max)
            //    {
            //        max = count;
            //        sym = str[i];
            //    }

            //}
            //Console.WriteLine($"Max Count = {max} , symbol = {sym}");
            #endregion
            #region Ex. 151 
            //Console.Write("How many numbers do you want to input: ");
            //int numCount = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input dividing number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input only numbers:");
            //string[] str = new string[numCount];
            //int indexNum = 0;
            //int sum = 0;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    str[i] = Console.ReadLine();
            //    indexNum = Convert.ToInt32(str[i]);
            //    if (indexNum%n == 0)
            //    {
            //        sum += indexNum;
            //    }
            //}
            //Console.WriteLine("_____________________________");
            //Console.WriteLine($"{sum}");
            #endregion

            #region Ex. 152
            //Console.Write("How many numbers do you want to input: ");
            //int numCount = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Input dividing number. it can not be zero: ");
            //int n;
            //do
            //{
            //    Console.Write("Divide number = ");
            //    n = Convert.ToInt32(Console.ReadLine());

            //} while (n <= 0);
            //Console.WriteLine("Input only numbers:");
            //string[] str = new string[numCount];
            //int indexNum = 0;
            //int result = 1;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    str[i] = Console.ReadLine();
            //    indexNum = Convert.ToInt32(str[i]);
            //    if (indexNum % n == 0)
            //    {
            //        result *= indexNum;
            //    }
            //}
            //Console.WriteLine("_____________________________");
            //Console.WriteLine($"{result}");
            #endregion

            #region Write a program in C# Sharp to extract a substring from a given string without using the library function.
            //Console.Write("Input string: ");
            //string str = Console.ReadLine();
            //Console.Write("Input position to start extraction(number): ");
            //int pos = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input the length of substring(number): ");
            //int subStr = Convert.ToInt32(Console.ReadLine());

            //for (int i = pos; i < pos+subStr; i++)
            //{
            //    Console.Write(str[i]);
            //}
            #endregion

            #region Write a C# Sharp program to check whether a given substring is present in the given string.
            //Console.Write("Input string: ");
            //string str = Console.ReadLine();
            //Console.Write("Input the substring to search: ");
            //string subStr = Console.ReadLine();

            //if (str.Contains(subStr))
            //{
            //    Console.WriteLine("The substring is exist:");
            //}
            //else
            //{
            //    Console.WriteLine("The substring is NOT exist:");
            //}
            #endregion


            #region Write a program in C# Sharp to read a sentence and replace lowercase characters by uppercase and vice-versa
            //Console.Write("Input string:");
            //string str = Console.ReadLine();

            //for (int i = 0; i < str.Length; i++)
            //{
            //    char ch = str[i];

            //    if (char.IsLower(ch))
            //    {
            //        Console.Write(char.ToUpper(ch));
            //    }
            //    else
            //    {
            //        Console.Write(char.ToLower(ch));
            //    }
            //}

            #endregion

            #region Write a program in C# Sharp to check the username and password




            #endregion









        }
    }
}
