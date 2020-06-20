using System;

namespace uri1013
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, y, z, maiorXY, maior;

            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);
            z = int.Parse(vet[2]);

            maiorXY = (x + y + Math.Abs(x - y)) / 2;

            maior = (maiorXY + z + Math.Abs(maiorXY - z)) / 2;

            Console.WriteLine(maior + " eh o maior");
        }
    }
}
