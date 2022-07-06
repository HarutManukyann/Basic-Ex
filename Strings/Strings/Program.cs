using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input string: ");
            string str = Console.ReadLine();
            int max = 0;
            char sym = ' ';
            for (int i = 0; i < str.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        count++;
                    }

                }
                if (count > max)
                {
                    max = count;
                    sym = str[i];
                }

            }
            Console.WriteLine($"Max Count = {max} , symbol = {sym}");


        }
    }
}
