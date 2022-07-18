using System;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero do qual deseja obter a Tabuada: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tabuada do " + n);

            for (int i = 0; i <= 10; i++)
            {
                int resultado = n * i;
                Console.WriteLine(n + " x " + i + " = " + resultado);

            }
        }
    }
}
