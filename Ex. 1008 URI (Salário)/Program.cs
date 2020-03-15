using System;
using System.Globalization;

namespace Ex._1008
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, h;
            double v, s;

            n = int.Parse(Console.ReadLine());
            h = int.Parse(Console.ReadLine());

            v = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);             

            s = h * v;

            Console.WriteLine("NUMBER = " + n);
            Console.WriteLine("SALARY = U$ " + s.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
