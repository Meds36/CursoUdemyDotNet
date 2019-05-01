using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Exercicios
{
    class ExercicioWhile
    {

        private int i = 0;
        public int Senha { get; set; }

        public ExercicioWhile()
        {
        }


        public void validarSenha()
        {

            Console.Write("Digite uma senha: ");
            Senha = int.Parse(Console.ReadLine());

            while (Senha != 2002)
            {
                Console.WriteLine("Senha inválida!");

                Console.Write("Digite outra senha: ");
                Senha = int.Parse(Console.ReadLine());


            }

            Console.WriteLine("Acesso permitido!");


        }

        public void ExWhile3()
        {
            Console.WriteLine("Digite sua preferência de acordo com os código abaixo: ");
            Console.WriteLine("1: Gasolina");
            Console.WriteLine("2: Etanol");
            Console.WriteLine("3: Diesel");
            Console.WriteLine("4: Fim");

            int tipo = int.Parse(Console.ReadLine());

            int gasolina = 0;
            int alcool = 0;
            int diesel = 0;

            while (tipo != 4)
            {
                if (tipo == 1)
                {
                    gasolina += 1;
                }

                else if (tipo == 2)
                {
                    alcool += 1;
                }

                else if (tipo == 3)
                {
                    diesel += 1;
                }

                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muito Obrigado!");
            Console.WriteLine("");
            Console.WriteLine("Gasolina: "+gasolina);
            Console.WriteLine("Etanol: "+ alcool);
            Console.WriteLine("Diesel: "+diesel);




        }


    }


}

