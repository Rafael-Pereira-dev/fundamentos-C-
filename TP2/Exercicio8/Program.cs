using System.Diagnostics;

namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma nota entre 0 a 10: ");
            int nota = int.Parse(Console.ReadLine());

            if (nota == 10)
            {
                Console.WriteLine("Excelente!");
            } else if (nota >= 8)
            {
                Console.WriteLine("Bom!");
            } else if (nota >= 6)
            {
                Console.WriteLine("Regular!");
            } else
            {
                Console.WriteLine("Insuficiente!");
            }
        }
    }
}
