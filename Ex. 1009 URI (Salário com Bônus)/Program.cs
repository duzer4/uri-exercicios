using System;
using System.Globalization;

namespace Ex._1009_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, vendas, total;

            nome = (Console.ReadLine());
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = (double) vendas * 15 / 100 + salario;

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
