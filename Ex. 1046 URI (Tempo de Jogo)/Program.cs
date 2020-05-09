using System;

namespace Ex._1046_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicial, final, duracao;

            string[] vs = Console.ReadLine().Split(' ');

            inicial = int.Parse(vs[0]);
            final = int.Parse(vs[1]);

            if (inicial < final)
            {
                duracao = final - inicial;
            }
            else
            {
                duracao = 24 - inicial + final;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");

        }
    }
}
