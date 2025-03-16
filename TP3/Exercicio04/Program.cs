namespace Exercicio04
{
    class Ingresso
    {
        public string nomeDoShow;
        public double preco;
        public int quantidadeDisponivel;

        public void AlterarPreco(double novoPreco)
        {
            preco = novoPreco;
            Console.WriteLine($"O preço do ingresso foi alterado para: R$ {preco}");
        }

        public void AlterarQuantidade(int novaQuantidade)
        {
            quantidadeDisponivel = novaQuantidade;
            Console.WriteLine($"A quantidade de ingressos foi alterada para: {quantidadeDisponivel}");
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Show: {nomeDoShow}");
            Console.WriteLine($"Preço do ingresso: R$ {preco}");
            Console.WriteLine($"Quantidade de ingressos: {quantidadeDisponivel}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Ingresso ingresso1 = new();

            ingresso1.nomeDoShow = "Dire Straits";
            ingresso1.preco = 150.0; ;
            ingresso1.quantidadeDisponivel = 318;

            ingresso1.ExibirInformacoes();
            Console.WriteLine();
            ingresso1.AlterarPreco(185.75);
            ingresso1.AlterarQuantidade(264);
            Console.WriteLine();
            ingresso1.ExibirInformacoes();
        }
    }
}
