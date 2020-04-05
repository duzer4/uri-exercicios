using System;
using System.Globalization;

namespace Ex._1015_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, distancia, a1, a2;

            string[]

            valor = Console.ReadLine().Split(' ');
            x1 = double.Parse(valor[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(valor[1], CultureInfo.InvariantCulture);

            valor = Console.ReadLine().Split(' ');
            x2 = double.Parse(valor[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(valor[1], CultureInfo.InvariantCulture);

            a1 = (double) Math.Pow(x2 - x1, 2.0);
            a2 = (double)Math.Pow(y2 - y1, 2.0);

            distancia = (double) Math.Sqrt(a1 + a2);

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
