using System.Globalization;
namespace Construtores
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {
            Quantidade = 0;
        }

        public Produto(string nome, double preco, int qtd) 
        {
            _nome = nome;
            Preco = preco;
            Quantidade = qtd;
        }

        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            Preco    = preco;
            //Quantidade = 5;
        }

        public string Nome
        {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }

            }
        }
   
 
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;

        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade = quantidade - quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", R$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)
                ;
        }





    }
}
