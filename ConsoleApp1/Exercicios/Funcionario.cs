using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Exercicios
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {

            return SalarioBruto - Imposto;
        }


        public void AumetarSalario(double porcentagem)
        {

            double reajust = SalarioBruto * ( porcentagem / 100);
            SalarioBruto = SalarioBruto + reajust;


        }

            





    }
}
