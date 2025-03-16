namespace Exercicio11
{
    class Circulo
    {
        public double raio;

        public double CalcularArea(double raio)
        {
            return Math.PI * Math.Pow(raio, 2);
        }
    }

    class Esfera
    {
        public double raio;

        public double CalcularVolume(double raio)
        {
            return (4.0 / 3) * Math.PI * Math.Pow(raio, 3);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
        }
    }
}
