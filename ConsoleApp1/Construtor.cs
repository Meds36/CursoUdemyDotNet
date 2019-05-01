using ConsoleApp1.Exercicios;
using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Construtor
    {
        static void Main(string[] args)
        {
            //Construtor c = new Construtor();
            //ExercicioWhile e = new ExercicioWhile();
            ExerciciosFOR ef = new ExerciciosFOR();
            ef.NumerosPorPeriodo();
            
        }

        public void calculaTriangulo()
        {
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("---Exercicio para verificar medidas de 2 triangulos e verificar qual eh o maior! ---");

            Console.WriteLine("Entre com as medidas do triangulo X ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("A area de X eh: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("A area de Y eh: " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadKey();

            if (areaX > areaY)
            {
                Console.WriteLine("A area maior eh a de X");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("A area maior eh a de Y");
                Console.ReadKey();

            }

        }
        public void ex1()
        {
            Console.WriteLine("Exercicio 1 - Qual é a pessoa mais velha?");
            Exercicio1 pessoaUm = new Exercicio1();
            Exercicio1 pessoaDois = new Exercicio1();

            Console.Write("Digite o nome da primeira pessoa: ");
            pessoaUm.nome = (Console.ReadLine());
            // Console.WriteLine("");
            Console.Write("Digite a idade da primeira pessoa: ");
            pessoaUm.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------");

            Console.Write("Digite o nome da segunda pessoa: ");
            pessoaDois.nome = (Console.ReadLine());
            //            Console.WriteLine("");
            Console.Write("Digite a idade da segunda pessoa: ");
            pessoaDois.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            if (pessoaUm.idade > pessoaDois.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + pessoaUm.nome);
                Console.WriteLine("Pressione a tecla Enter para sair...");
                Console.ReadKey();


            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + pessoaDois.nome);
                Console.WriteLine("Pressione a tecla Enter para sair...");
                Console.ReadKey();
            }
        }
        public void exe2()
        {
            Console.WriteLine("Exercicio 2- Verifica media de salario");

            Exercicio2 funcUm = new Exercicio2();
            Exercicio2 funcDois = new Exercicio2();

            Console.Write("Digite o nome do funcionario 1: ");
            funcUm.Nome = Console.ReadLine();
            Console.Write("Digite o salario do funcionario 1: ");
            funcUm.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.Write("Digite o nome do funcionario 2: ");
            funcDois.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salario do funcionario 2: ");
            funcDois.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Dados do primeiro funcionario >> Nome: " + funcUm.Nome + "Salario: " + funcUm.Salario);
            Console.WriteLine("Dados do segundo funcionario >> Nome: " + funcDois.Nome + "Salario: " + funcDois.Salario);

            double media = funcUm.Salario + funcDois.Salario / 2;
            Console.WriteLine("Salario Medio: " + media.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Pressione Enter para Finalizar...");
            Console.ReadKey();


        }
        public void product()
        {
            Produto p = new Produto();

            Console.WriteLine("---- Exercicio 3 - Produtos! ----");
            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine("");

            Console.Write("Digite o número de produtos a ser adicionados em estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);
            Console.WriteLine("");
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine("");
            Console.Write("Digite o número de produtos a serem removidos do estoque: ");
            qtd = int.Parse(Console.ReadLine());

            p.RemoverProdutos(qtd);
            Console.WriteLine("Dados atualizados: " + p);

        }
        public void retangulo()
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("----Exercicio Retangulo----");
            Console.Write("Digite o valor da largura: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o valor da Altura: ");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");
            Console.WriteLine(r);


        }
        public void func()
        {
            Funcionario f = new Funcionario();

            Console.WriteLine("---Reajustar salario funcionario---");
            Console.WriteLine("");
            Console.Write("Digite o nome do funcionario: ");
            f.Nome = Console.ReadLine();
            Console.Write("Digite o salario bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
         
            Console.Write("Salario liquido: "+ f.SalarioLiquido().ToString());
            
            Console.WriteLine("");
            Console.Write("Digite o valor do reajuste: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumetarSalario(porcentagem);
            Console.WriteLine("");
            Console.WriteLine("Dados Atualizados: " + f.Nome + ", R$ "+ f.SalarioLiquido().ToString(), "F2", CultureInfo.InvariantCulture);
            
                                         }
        public void aluno()
        {
            Aluno a = new Aluno();

            Console.WriteLine("---Monstrar nota e situação de aprovação do aluno ---");
            Console.Write("Digite o nome do aluno: ");
            a.nome = Console.ReadLine();
            Console.Write("Digite a nota do primeiro trimestre: ");
            a.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a nota do segundo trimestre: ");
            a.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a nota do terceiro trimestre: ");
            a.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           Console.WriteLine( a.CalcularMedia().ToString());




        }

        public void enquanto()
        {

            Console.Write("Digite um número: ");
            double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (n >= 0)
            {
                double raiz = Math.Sqrt(n);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));

                Console.Write("Digite outro número: ");
                n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
              

            }

            Console.WriteLine("NUMERO NEGATIVO!!");
            Console.ReadKey();


            ;

        }

    }
}
