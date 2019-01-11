using System;

namespace URI_1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);
            if (A > B && A > C)
            {
                Console.WriteLine(A + " eh o maior");
            }
            else if (B > C)
            {
                Console.WriteLine(B + " eh o maior");
            }
            else
            {
                Console.WriteLine(C + " eh o maior");
            }
            Console.ReadLine();
        }
    }
}
