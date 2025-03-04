namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a temperatura em graus Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;
            double kelvin = celsius + 273.15;

            Console.WriteLine($"\nTemperatura em Fahrenheit: {fahrenheit:F2} °F");
            Console.WriteLine($"Temperatura em Kelvin: {kelvin:F2} K");

        }
    }
}
