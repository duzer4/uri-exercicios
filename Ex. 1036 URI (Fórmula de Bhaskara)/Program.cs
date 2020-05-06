using System;
using System.Globalization;

namespace Ex._1036_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;

            string[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = (double) ((Math.Pow(b, 2.0))) - 4.0 * a * c;

            if (a == 0.0 || delta <= 0.0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                x1 = (double) (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (double) (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("R1 = " + x1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + x2.ToString("F5", CultureInfo.InvariantCulture));
            }
        }
    }
}
