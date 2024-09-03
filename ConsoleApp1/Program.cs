using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Solicitar os pesos do usuário
            Console.WriteLine("Digite o peso W1:");
            double w1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o peso W2:");
            double w2 = Convert.ToDouble(Console.ReadLine());

            // Criar o NeuronioArtificial com os pesos fornecidos
            NeuronioArtificial neuronioArtificial = new NeuronioArtificial(0.5, w1, w2);

            // Criar uma lista de entradas para treinamento
            List<Entradas> listaEntradas = new List<Entradas>
            {
                new Entradas(0.0, 0.0, 0),
                new Entradas(0.0, 1.0, 1),
                new Entradas(1.0, 0.0, 1),
                new Entradas(1.0, 1.0, 1)
            };

            // Treinar o neurônio
            neuronioArtificial.Treinar(listaEntradas);

            // Testar o neurônio
            Console.WriteLine("Resultado para (0,0): " + neuronioArtificial.Perguntar(0.0, 0.0));
            Console.WriteLine("Resultado para (0,1): " + neuronioArtificial.Perguntar(0.0, 1.0));
            Console.WriteLine("Resultado para (1,0): " + neuronioArtificial.Perguntar(1.0, 0.0));
            Console.WriteLine("Resultado para (1,1): " + neuronioArtificial.Perguntar(1.0, 1.0));
        }
    }
}
