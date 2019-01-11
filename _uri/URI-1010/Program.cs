using System;
using System.Globalization;

namespace URI_1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigoPeca1, codigoPeca2, quantidadeDePeca1, quantidadeDePeca2;
            double valorPeca1, valorPeca2, totalPagar;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            codigoPeca1 = int.Parse(vet[0]);
            quantidadeDePeca1 = int.Parse(vet[1]);
            valorPeca1 = double.Parse(vet[2], CultureInfo.InvariantCulture);


            vet = Console.ReadLine().Split(' ');
            codigoPeca2 = int.Parse(vet[0]);
            quantidadeDePeca2 = int.Parse(vet[1]);
            valorPeca2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            totalPagar = quantidadeDePeca1 * valorPeca1 + quantidadeDePeca2 * valorPeca2;

            Console.WriteLine("VALOR A PAGAR: R$ " + totalPagar.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
