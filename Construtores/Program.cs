using System;
using System.Globalization;

namespace Construtores
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria conta;

            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial? s/n: ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(nome, numero, depositoInicial);

            }
            else
            {
                conta = new ContaBancaria(nome, numero);

            }

            Console.WriteLine(conta);

            Console.Write("Entre com o valor do depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(deposito);

            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta.ToString());

            Console.WriteLine("Entre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(saque);

            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta.ToString());

        }
    }
}
