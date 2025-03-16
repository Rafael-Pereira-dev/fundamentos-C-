namespace Exercicio06
{
/* O uso de construtores traz mais controle, segurança, clareza e simplicidade na criação de objetos.
Ele permite que o objeto seja inicializado de forma mais compacta, consistente e com menor chance de erros, já que todos
os atributos obrigatórios são passados de uma vez e no momento da criação do objeto.

Já os métodos set oferecem flexibilidade, mas podem tornar o código mais extenso e difícil de controlar, especialmente
quando há muitos atributos para serem definidos. Isso pode levar a objetos com estados inválidos ou incompletos, caso
algum valor importante não seja configurado corretamente.*/
    class Ingresso
    {
        public string nomeDoShow;
        public double preco;
        public int quantidadeDisponivel;

        public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel)
        {
            this.nomeDoShow = nomeDoShow;
            this.preco = preco;
            this.quantidadeDisponivel = quantidadeDisponivel;
        }

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
            Ingresso ingresso1 = new("Dire Straits", 150.0, 318);

            ingresso1.ExibirInformacoes();
            Console.WriteLine();
            ingresso1.SetPreco(185.75);
            ingresso1.SetQuantidadeDisponivel(264);
            Console.WriteLine();
            ingresso1.ExibirInformacoes();
        }
    }
}