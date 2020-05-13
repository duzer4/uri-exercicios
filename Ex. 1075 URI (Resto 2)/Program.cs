using System;
using System.Globalization;

namespace Ex._1075_URI__Resto_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            for (int i = 1; i < 10000; i++)
            {
                if (i % N == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
