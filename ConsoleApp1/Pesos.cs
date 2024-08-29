using System;

namespace ConsoleApp1
{
    public class Pesos
    {
        private static readonly Random random = new Random();

        public Pesos(double w1, double w2)
        {
            W1 = w1;
            W2 = w2;
        }

        public Pesos()
        {
            GerarAleatorio();
        }

        public double W1 { get; set; }
        public double W2 { get; set; }

        public void GerarAleatorio()
        {
            W1 = 2 * random.NextDouble() - 1; // Gera valores entre -1 e 1
            W2 = 2 * random.NextDouble() - 1; // Gera valores entre -1 e 1
        }

    }
}
