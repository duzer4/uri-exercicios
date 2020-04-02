using System;

namespace Ex._1013_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, maiorab, maior;

            string[] valores = Console.ReadLine().Split(' ');
            a = int.Parse(valores[0]);
            b = int.Parse(valores[1]);
            c = int.Parse(valores[2]);

            maiorab = (a + b + Math.Abs(a - b)) / 2;

            maior = (maiorab + c + Math.Abs(maiorab - c)) / 2;

            Console.WriteLine(maior + " eh o maior");
        }
    }
}
