namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a primeira data (dd/MM/yyyy): ");
            string input1 = Console.ReadLine();

            Console.Write("Digite a segunda data (dd/MM/yyyy): ");
            string input2 = Console.ReadLine();

            DateTime data1;
            DateTime data2;

            bool data1Valida = DateTime.TryParseExact(input1, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out data1);
            bool data2Valida = DateTime.TryParseExact(input2, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out data2);

            if (data1Valida && data2Valida)
            {
                TimeSpan diferenca = data2 - data1;
                int totalDias = Math.Abs(diferenca.Days);

                int anos = totalDias / 365;
                int meses = (totalDias % 365) / 30; 
                int dias = (totalDias % 365) % 30;

                Console.WriteLine($"A diferença entre as duas datas é de {anos} anos, {meses} meses e {dias} dias.");
            }
            else
            {
                Console.WriteLine("Uma ou ambas as datas são inválidas. Informe as datas no formato dd/MM/yyyy.");
            }
        }
    }
}
