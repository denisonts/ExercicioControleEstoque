using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace ExercicioControleEstoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Produto item = new Produto();
            
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            item.Nome = Console.ReadLine();
                          
            Console.Write("Preço: ");
            item.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            item.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + item);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");

            Console.WriteLine();
            int qte = int.Parse(Console.ReadLine());
            item.AdicionarProduto(qte);
            Console.WriteLine("Dados Atualizados: " + item);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido ao estoque: ");

            Console.WriteLine();
            int qte2 = int.Parse(Console.ReadLine());
            item.RemoverProduto(qte2);
            Console.WriteLine("Dados Atualizados: " + item);


        }
    }
}
