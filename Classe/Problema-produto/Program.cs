using System;

namespace Course
{
    public class Produto
    {
        public string nome;
        public double preco;
        public int quantidade;

        public double ValorTotalEmEstoque()
        {
            return preco * quantidade;
        }
        public override string ToString()
        {
            return nome + ", $ " + preco;
        }

        public void AdicionarProdutos(int a)
        {

        }
        public void RemoverProdutos(int a)
        {

        }
    }
    class Program
    {
        static void Main()
        {
            Produto item = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            item.nome = Console.ReadLine();
            Console.Write("Preço: ");
            item.preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            item.quantidade = int.Parse(Console.ReadLine());

            double total = item.ValorTotalEmEstoque();

            Console.WriteLine("Dados do produto: {0}, $ {1}, {2} unidades, Total: $ {3}\n", item.nome, item.preco, item.quantidade, total);

            

        }
    }
}