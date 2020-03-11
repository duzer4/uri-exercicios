using System;
using System.Globalization;

namespace Ex._1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, n, R;

            n = 3.14159;
            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);            
            area = n * R * R;

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
