namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua data de nascimento (dd/MM/yyyy): ");
            string input = Console.ReadLine();

            DateTime dataNascimento;
            if (DateTime.TryParseExact(input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataNascimento))
            {
              
                DateTime dataAtual = DateTime.Now;

                DateTime proximoAniversario = new DateTime(dataAtual.Year, dataNascimento.Month, dataNascimento.Day);

                if (proximoAniversario < dataAtual)
                {
                    proximoAniversario = new DateTime(dataAtual.Year + 1, dataNascimento.Month, dataNascimento.Day);
                }

                TimeSpan diferenca = proximoAniversario - dataAtual;
                int diasFaltando = diferenca.Days;

                Console.WriteLine($"Faltam {diasFaltando} dias para o seu próximo aniversário.");
            }
            else
            {
                Console.WriteLine("Data inválida. Informe data no formato correto (dd/MM/yyyy).");
            }
        }
    }
}
