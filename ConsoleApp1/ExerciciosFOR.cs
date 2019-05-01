using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ConsoleApp1
{
    class ExerciciosFOR
    {

        public void ExibirNumerosImpares()
        {
            int resultado;
            Console.Write("Digite um número inteiro: ");
            int x = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for (int i = 1; i <= x; i++)
            {
                resultado = i % 2;

                if (resultado != 0)
                {
                    Console.WriteLine(i);
                }

            }


        }

        public void NumerosPorPeriodo()
        {
            int inPeriodo = 0;
            int outPeriodo = 0;


            Console.Write("Digite um numero: ");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for (int i = 1; i <= n; i++)
            {
                int x = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (x >= 10 && x <= 20)
                {
                    inPeriodo += 1;

                }
                else
                {
                    outPeriodo += 1;
                }
            }

            Console.WriteLine("In: "+inPeriodo);
            Console.WriteLine("Out: " + outPeriodo);

        }






    }
}