using System;
using System.Globalization;

namespace Ex._1048_URI__Aumento_de_Salário_
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, novo, reajuste, percentual;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario >= 0 && salario <= 400.00)
            {
                percentual = 15.0;
                reajuste = salario * percentual / 100.0;
                novo = salario + reajuste;
            }
            else if (salario >= 400.01 && salario <= 800.00)
            {
                percentual = 12.0;
                reajuste = salario * percentual / 100.0;
                novo = salario + reajuste;
            }
            else if (salario >= 800.01 && salario <= 1200.00)
            {
                percentual = 10.0;
                reajuste = salario * percentual / 100.0;
                novo = salario + reajuste;
            }
            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                percentual = 7.0;
                reajuste = salario * percentual / 100.0;
                novo = salario + reajuste;
            }
            else
            {
                percentual = 4.0;
                reajuste = salario * percentual / 100.0;
                novo = salario + reajuste;
            }

            Console.WriteLine("Novo salario: " + novo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual.ToString("F0", CultureInfo.InvariantCulture) + " %");
        }
    }
}
