using System;
using System.Globalization;

namespace Ex._1011_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, pi, v;            

            r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            pi = 3.14159;
            v = (double) (4.0 / 3) * pi * Math.Pow(r, 3.0);

            Console.WriteLine("VOLUME = " + v.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
