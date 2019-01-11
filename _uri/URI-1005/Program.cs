using System;
using System.Globalization;

namespace URI_1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, media;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            media = ((a * 3.5) + (b * 7.5)) / 11;
            Console.WriteLine("media = " + media.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
