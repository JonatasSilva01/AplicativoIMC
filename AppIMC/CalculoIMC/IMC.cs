using System;
using Modelo;
using System.Collections.Generic;
using System.Text;
using Diretorio;

namespace CalculoIMC
{
    public class IMC : Arquivos
        // Regra de Negocio com calculos
    {
        protected double Peso { get; set; }
        protected double Altura { get; set; }
        protected double ResultadoImc { get; set; }

        protected void SetCalculoImc(double Peso, double Altura)
        {
            ResultadoImc = Peso / (Altura * Altura);
            Console.WriteLine($"Calculo do IMC Feito e deu: {ResultadoImc}");
        }
    }
}
