using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Construtores
{
    class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string Nome { get; set; }

        public double Saldo { get; private set; }

        public ContaBancaria(string nome, int numeroConta)
        {
            Nome = nome;
            NumeroConta = numeroConta;

        }

        public ContaBancaria(string nome, int numeroConta, double depositoInicial) : this(nome, numeroConta)
        {
            Depositar(depositoInicial);
        }


        public void Depositar(double valor)
        {

            Saldo = Saldo + valor;
        }

        public double Sacar(double valor)
        {
            double taxaSaque = 5.00;
            Saldo = Saldo - (valor + taxaSaque);

            return Saldo;
        }

        public override string ToString() => "Conta: "
                +
                NumeroConta
                + ", Titular: "
                + Nome
                + ", Saldo: "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);

    }
}
