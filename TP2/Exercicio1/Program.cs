namespace Exercicio1
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

                int anos = dataAtual.Year - dataNascimento.Year;
                int meses = dataAtual.Month - dataNascimento.Month;
                int dias = dataAtual.Day - dataNascimento.Day;

                if (meses < 0)
                {
                    anos--;
                    meses += 12;
                }

                if (dias < 0)
                {
                    meses--;

                    int diasNoMesAnterior = DateTime.DaysInMonth(dataAtual.Year, dataAtual.Month - 1);
                    dias += diasNoMesAnterior;
                }

                Console.WriteLine($"Sua idade é: {anos} anos, {meses} meses e {dias} dias.");
            }
            else
            {
                Console.WriteLine("Data inválida. Informe a data no formato correto (dd/MM/yyyy).");
            }
        }
    }
}
