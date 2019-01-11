using System;

namespace URI_1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, anos, meses, dias, resto;

            n = int.Parse(Console.ReadLine());

            anos = n / 365;
            resto = n % 365;
            meses = resto / 30;
            dias = resto % 30;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
        }
    }
}
