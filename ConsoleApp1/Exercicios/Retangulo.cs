using System.Globalization;
using System;

namespace ConsoleApp1.Exercicios
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {

            return Largura * Altura;
        }

        public double Perimetro()
        {

            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {

            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }

        public override string ToString()
        {
            return
            "Area: " + Area().ToString("F2", CultureInfo.InvariantCulture)
            + " Perimetro: " + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
            +" Diagonal " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
         
        }
    }
}
