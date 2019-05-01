using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ConsoleApp1.Exercicios
{
    class Aluno
    {
        public string nome;
        public double nota1;
        public double nota2;
        public double nota3;
        public double notaFinal;

        public string CalcularMedia()
        {


            notaFinal  = nota1 + nota2 + nota3;

           if(notaFinal >= 60)
            {
                return "NOTA FINAL: '" + notaFinal.ToString() + "' APROVADO!";
               
              
            }
            else
            {
                double resto = 60 - notaFinal;

                return "NOTA FINAL: '" + notaFinal.ToString() + 
                        "' REPROVADO! FALTAM '" + resto.ToString() + "' PONTOS"  ;
                
            }
           
        }



    }
}
