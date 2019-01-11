using System;
using System.Globalization;
namespace URI_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;

            double salario, totalVendas, totalAReceber;

            nome = Console.ReadLine();

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            totalAReceber = (double)salario + ((totalVendas * 15) / 100);

            Console.WriteLine("TOTAL = R$ " + totalAReceber.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
