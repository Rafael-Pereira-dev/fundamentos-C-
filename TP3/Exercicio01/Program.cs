namespace Exercicio01
{
/* Classe: Define o modelo (plano) para os objetos, especificando os atributos e métodos.
Objeto: É uma instância de uma classe, com valores próprios para seus atributos e com a capacidade de executar métodos.
Campos (ou Atributos): Representam as características de um objeto e são definidos dentro da classe.
Métodos: São as funções ou ações que os objetos podem realizar, definidas dentro da classe. */

    class Carro
    {
        public string modelo;
        public string placa;
        public string cor;
        public int num_portas;

        public void exibirInformacoes()
        {
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Placa: {placa}");
            Console.WriteLine($"Cor: {cor}");
            Console.WriteLine($"Número de portas: {num_portas}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new();

            carro1.modelo = "Fusca";
            carro1.placa = "XYZ123";
            carro1.cor = "preto";
            carro1.num_portas = 2;

            carro1.exibirInformacoes();
        }
    }
}
