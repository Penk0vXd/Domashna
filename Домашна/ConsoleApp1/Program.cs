using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > max)
                {
                    max = num[i];
                }
                if (num[i] < min)
                {
                    min = num[i];
                }
            }

            Console.WriteLine($"Най-големият елемент е: {max}");
            Console.WriteLine($"Най-малкият елемент е: {min}");
        }
    }
}
