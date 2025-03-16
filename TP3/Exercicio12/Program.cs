namespace Exercicio12
{
    class Circulo
    {
        public double raio;

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(raio, 2);
        }
    }

    class Esfera
    {
        public double raio;

        public double CalcularVolume()
        {
            return (4.0 / 3) * Math.PI * Math.Pow(raio, 3);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo1 = new();
            Esfera esfera1 = new();

            circulo1.raio = 3.0;
            esfera1.raio = 5.0;

            Console.WriteLine("Área do círculo: " + circulo1.CalcularArea());
            Console.WriteLine("Volume da esfera: " + esfera1.CalcularVolume());
        }
    }
}
