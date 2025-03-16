namespace Exercicio08
{
    class Matricula
    {
        public string nomeDoAluno;
        public string curso;
        public int numeroMatricula;
        public string situacao;
        public string dataInicial;

        public void Trancar()
        {
            situacao = "Trancada";
        }

        public void Reativar()
        {
            situacao = "Ativa";
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Aluno: {nomeDoAluno}");
            Console.WriteLine($"Cruso: {curso}");
            Console.WriteLine($"Matrícula: {numeroMatricula}");
            Console.WriteLine($"Situação: {situacao}");
            Console.WriteLine($"Data da matrícula: {dataInicial}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
