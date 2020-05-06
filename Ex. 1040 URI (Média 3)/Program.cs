﻿using System;
using System.Globalization;

namespace Ex._1040_URI__Média_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            float N1, N2, N3, N4, media, exame, final;

            string[] vs = (Console.ReadLine().Split(' '));

            N1 = float.Parse(vs[0], CultureInfo.InvariantCulture);
            N2 = float.Parse(vs[1], CultureInfo.InvariantCulture);
            N3 = float.Parse(vs[2], CultureInfo.InvariantCulture);
            N4 = float.Parse(vs[3], CultureInfo.InvariantCulture);

            media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10;

            if (media == 4.85f)
            {
                media = 4.8f;
            }

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                exame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + exame.ToString("F1", CultureInfo.InvariantCulture));
                final = (exame + media) / 2;

                if (final >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + final.ToString("F1", CultureInfo.InvariantCulture));
            }
             
        }
    }
}