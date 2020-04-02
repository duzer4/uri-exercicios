using System;
using System.Globalization;

namespace Ex._1014_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double y, z;

            x = int.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            z = (double) x / y;

            Console.WriteLine(z.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
