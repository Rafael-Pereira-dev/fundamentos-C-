using System.Collections.Generic;

namespace Exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Até R$ 1.500,00: Isento de impostos
            De R$ 1.500,01 até R$ 3.000,00: 10 % de imposto
            De R$ 3.000,01 até R$ 5.000,00: 15 % de imposto
            Acima de R$ 5.000,00: 20 % de imposto*/

            Console.Write("Digite o salário bruto: R$ ");
            double salarioBruto = double.Parse(Console.ReadLine());

            double descontoImposto = 0;
            double salarioLiquido;

            if (salarioBruto <= 1500)
            {
                descontoImposto = 0; 
            }
            else if (salarioBruto <= 3000)
            {
                descontoImposto = salarioBruto * 0.10; 
            }
            else if (salarioBruto <= 5000)
            {
                descontoImposto = salarioBruto * 0.15; 
            }
            else
            {
                descontoImposto = salarioBruto * 0.20; 
            }

            salarioLiquido = salarioBruto - descontoImposto;

            Console.WriteLine("");
            Console.WriteLine($"Salário Bruto: R$ {salarioBruto:F2}");
            Console.WriteLine($"Desconto de Imposto: R$ {descontoImposto:F2}");
            Console.WriteLine($"Salário Líquido: R$ {salarioLiquido:F2}");
        }
    }
}
