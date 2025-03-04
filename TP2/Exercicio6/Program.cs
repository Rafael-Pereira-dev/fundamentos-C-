namespace Exercicio6
{
    internal class Program
    {
        static string ClassificacaoIMC(double imc)
        {
            if (imc < 18.5)
            {
                return "Classificação: Abaixo do peso";
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                return "Classificação: Peso normal";
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                return "Classificação: Sobrepeso";
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                return "Classificação: Obesidade grau 1";
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                return "Classificação: Obesidade grau 2 (severa)";
            }
            else
            {
                return "Classificação: Obesidade grau 3 (mórbida)";
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Digite o seu peso (em kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite a sua altura (em metros): ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine($"\nSeu IMC é: {imc:F2}");
            Console.WriteLine(ClassificacaoIMC(imc));
        }
    }
}
