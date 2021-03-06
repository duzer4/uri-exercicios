﻿using System;
using System.Globalization;

namespace Ex._1010
{
    class Program
    {
        static void Main(string[] args)
        {

            int c1, n1, c2, n2;
            double v1, v2, vt;

            string[] valores = Console.ReadLine().Split(' ');

            c1 = int.Parse(valores[0]);
            n1 = int.Parse(valores[1]);
            v1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');

            c2 = int.Parse(valores[0]);
            n2 = int.Parse(valores[1]);
            v2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            vt = v1 * n1 + v2 * n2;

            Console.WriteLine("VALOR A PAGAR: R$ " + vt.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
