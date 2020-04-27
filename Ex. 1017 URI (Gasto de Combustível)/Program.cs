using System;
using System.Globalization;

namespace Ex._1017_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo, velocidade, distancia;
            double litros;

            tempo = int.Parse(Console.ReadLine());
            velocidade = int.Parse(Console.ReadLine());

            distancia = tempo * velocidade;

            litros = (double) distancia / 12;

            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
