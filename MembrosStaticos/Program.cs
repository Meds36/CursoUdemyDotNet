using System;
using System.Globalization;

namespace MembrosStaticos
{
    class Program
    {



        static void Main(string[] args)
        {

            Program p = new Program();
            p.cotacaoDolar();
                       
            
        }


        public void calc()
        {

            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));



            Console.ReadKey();



        }

        public void cotacaoDolar()
        {

            Console.Write("Qual a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dolares pretende comprar? ");
            double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(ConcversorDeMoeda.CalcularCotacao(cotacao, qtd));
            Console.ReadKey();
        }



    }
}
