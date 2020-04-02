using System;
using System.Globalization;

namespace Ex._1012_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            //a1 = area do triangulo retangulo, a2 = area do circulo, a3 = area do trapezio, a4 = area do quadrado
            //a5 = area do retangulo

            double A, B, C, a1, pi, a2, a3, a4, a5;

            string[] vetor = Console.ReadLine().Split(' ');

            A = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            B = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            C = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            a1 = (double) A * C / 2.0;
            pi = 3.14159;
            a2 = (double) pi * Math.Pow(C, 2.0);
            a3 = (double) (A + B) * C / 2.0;
            a4 = Math.Pow(B, 2.0);
            a5 = A * B;

            Console.WriteLine("TRIANGULO: " + a1.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + a2.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + a3.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + a4.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + a5.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
