namespace Exercicio09
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
            Console.WriteLine($"Curso: {curso}");
            Console.WriteLine($"Matrícula: {numeroMatricula}");
            Console.WriteLine($"Situação: {situacao}");
            Console.WriteLine($"Data da matrícula: {dataInicial}");
            Console.WriteLine();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Matricula matricula1 = new();

            matricula1.nomeDoAluno = "Rafael";
            matricula1.curso = "Eng Software";
            matricula1.numeroMatricula = 123456;
            matricula1.situacao = "Ativa";
            matricula1.dataInicial = "01/03/2024";


            matricula1.ExibirInformacoes();
            matricula1.Trancar();
            matricula1.ExibirInformacoes();
            matricula1.Reativar();
            matricula1.ExibirInformacoes();
        }
    }
}
