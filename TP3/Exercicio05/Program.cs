namespace Exercicio05
{
/*Os métodos getters e setters servem para acessar e modificar os valores das variáveis de uma classe de forma
controlada e segura. A principal finalidade desses métodos é proteger os dados de uma classe, permitindo que a classe
controle como os valores de suas variáveis são acessados e modificados.*/
    class Ingresso
    {
        public string nomeDoShow;
        public double preco;
        public int quantidadeDisponivel;

        public string GetNomeDoShow()
        {
            return nomeDoShow;
        }

        public void SetNomeDoShow(string novoNome)
        {
            nomeDoShow = novoNome;
        }

        public double GetPreco()
        {
            return preco;
        }

        public void SetPreco(double novoPreco)
        {
            preco = novoPreco;
        }

        public int GetQuantidadeDisponivel()
        {
            return quantidadeDisponivel;
        }

        public void SetQuantidadeDisponivel(int novaQuantidade)
        {
            quantidadeDisponivel = novaQuantidade;
        }

        //public void AlterarPreco(double novoPreco)
        //{
        //    preco = novoPreco;
        //    Console.WriteLine($"O preço do ingresso foi alterado para: R$ {preco}");
        //}

        //public void AlterarQuantidade(int novaQuantidade)
        //{
        //    quantidadeDisponivel = novaQuantidade;
        //    Console.WriteLine($"A quantidade de ingressos foi alterada para: {quantidadeDisponivel}");
        //}

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

            ingresso1.SetNomeDoShow("Dire Straits");
            ingresso1.SetPreco(150.0);
            ingresso1.SetQuantidadeDisponivel(318);

            ingresso1.ExibirInformacoes();
            Console.WriteLine();
            ingresso1.SetPreco(185.75);
            ingresso1.SetQuantidadeDisponivel(264);
            Console.WriteLine();
            ingresso1.ExibirInformacoes();
        }
    }
}

