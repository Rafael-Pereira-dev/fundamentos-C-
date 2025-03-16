using System.Runtime.CompilerServices;

namespace Exercicio03
{
    class Ingresso
    {
        public string nomeDoShow;
        public double preco;
        public int quantidadeDisponivel;

        public void AlterarPreco(double novoPreco)
        {
            preco = novoPreco;
            Console.WriteLine($"O preço do ingresso foi alterado para: R${preco}");
        }

        public void AlterarQuantidade(int novaQuantidade)
        {
            quantidadeDisponivel = novaQuantidade;
            Console.WriteLine($"A quantidade de ingressos foi alterada para: {quantidadeDisponivel}");
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Show: {nomeDoShow}");
            Console.WriteLine($"Preço do ingresso: R${preco}");
            Console.WriteLine($"Quantidade de ingressos: {quantidadeDisponivel}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
