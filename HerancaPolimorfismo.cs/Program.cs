using HerancaPolimorfismo.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            Account acc = new Account(1001, "Alex", 0.0);
            BussinesAccount bcc = new BussinesAccount(1001, "Maria", 0.00, 500.00);

            //UPCASTING

            Account ACC1 = bcc;
            Account ACC2 = new BussinesAccount(1002, "Bob", 500.0, 200.00);
            Account ACC3 = new SavingsAccount(1003, "Bob", 500.0, 200.00);

            ACC2.Withdraw(10.0);
            ACC3.Withdraw(10.0);

            Console.WriteLine(ACC2.Balance);
            Console.WriteLine(ACC3.Balance);
            Console.ReadKey();

        }
    }
}
