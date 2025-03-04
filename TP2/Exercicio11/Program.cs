namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para consultar a sua tabuada: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nTabuada do {num}:");

            for (int i = 1; i <= 10; i++)
            {
                int resultado = num * i;
                Console.WriteLine($"{num} x {i} = {resultado}");
            }
        }
    }
}
