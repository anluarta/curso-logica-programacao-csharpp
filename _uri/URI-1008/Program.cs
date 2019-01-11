using System;
using System.Globalization;

namespace URI_1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, horas;
            double valorPorHora, salario;
            numero = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salario = horas * valorPorHora;
            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

