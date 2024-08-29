using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class NeuronioArtificial
    {
        public Pesos Pesos { get; set; }
        public double O { get; set; }
        public double TaxaAprendizado { get; set; }

        public NeuronioArtificial(double taxaAprendizado)
        {
            O = 0.0;
            TaxaAprendizado = taxaAprendizado;
            Pesos = new Pesos();
        }

        public void Treinar(List<Entradas> listaEntradas)
        {
            foreach (var item in listaEntradas)
            {
                O = item.Entrada1 * Pesos.W1 + item.Entrada2 * Pesos.W2;
                int resultadoObtido = FuncaoClassificacao(O);
                int erro = item.ResultadoEsperado - resultadoObtido;

                if (erro != 0)
                {
                    // Recalcular os pesos
                    Pesos.W1 += TaxaAprendizado * erro * item.Entrada1;
                    Pesos.W2 += TaxaAprendizado * erro * item.Entrada2;
                }
            }
        }


        public int FuncaoClassificacao(double o)
        {
            return o >= 0 ? 1 : 0;
        }

        public int Perguntar(double X1, double X2)
        {
            double resultado = X1 * Pesos.W1 + X2 * Pesos.W2;
            return FuncaoClassificacao(resultado);
        }
    }
}
