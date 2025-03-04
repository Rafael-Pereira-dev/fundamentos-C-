namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int numeroSorteado = random.Next(1, 101);
            int palpite;

            do
            {
                Console.WriteLine("Qual o número foi sorteado? ");
                palpite = int.Parse(Console.ReadLine());

                if (palpite > numeroSorteado)
                {
                    Console.WriteLine("O palpite é maior que o número sorteado.");
                }
                else if (palpite < numeroSorteado)
                {
                    Console.WriteLine("O palpite é menor que o número sorteado.");
                }
                else
                {
                    Console.WriteLine("Parabéns, você acertou!");
                }

            } while (numeroSorteado != palpite);

        }
    }
}
