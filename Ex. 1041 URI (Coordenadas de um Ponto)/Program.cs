using System;
using System.Globalization;

namespace Ex._1041_URI__Coordenadas_de_um_Ponto_
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            string[] vs = Console.ReadLine().Split(' ');

            x = double.Parse(vs[0], CultureInfo.InvariantCulture);
            y = double.Parse(vs[1], CultureInfo.InvariantCulture);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
    }
}