using System.Security.AccessControl;

namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu telefone de contato: ");
            string telefone = Console.ReadLine();

            Console.WriteLine("Informe seu e-mail de contato: ");
            string email = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("*** SEUS DADOS ***");
            Console.WriteLine($"O seu nome é: {nome}");
            Console.WriteLine($"A sua idade é: {idade}");
            Console.WriteLine($"O seu telefone é: {telefone}");
            Console.WriteLine($"O seu e-mail é: {email}");

        }
    }
}
