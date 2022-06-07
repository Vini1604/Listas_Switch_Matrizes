using System;
using System.Collections.Generic;
using System.Linq;
namespace Listas
{
    class Program
    {
        static void ImprimeLista(List<Produto> produtos)
        {
            foreach (Produto produto in produtos)
            {
                Console.WriteLine(produto);
            }
        }

        static string VerificaMouseLogitech(List<Produto> produtos)
        {
            int indiceMouseLogitech = produtos.FindIndex(x => x.Nome.ToUpper() == "MOUSE LOGITECH");
            if (indiceMouseLogitech != -1)
            {
                return $"O produto Mouse Logitech se encontra no indice {indiceMouseLogitech} da lista";
            }
            else
            {
                return "O produto Mouse Logitech nao esta na lista";
            }
        }

        static void Main(string[] args)
        {

            List<Produto> produtos = new List<Produto>(){
                new Produto("HDD", 350.00M),
                new Produto("SSD", 500.00M),
                new Produto("Teclado", 50.00M),
                new Produto("Memoria RAM 8GB", 440.00M),
                new Produto("Mouse logitech", 60.00M),
                new Produto("Pen Drive", 40.00M),
                new Produto("AMD", 1800.00M),
                new Produto("Fone de ouvido", 80.00M),
                new Produto("Microfone", 60.00M),
                new Produto("Monitor LCD", 1300.00M)
            };

            // BLOCO COMENTADO CASO A LISTA INICIAL SEJA INFORMADA PELO USUARIO
            /*
            string nomeProduto;
            decimal precoProduto;
            int numeroProdutos = 10;
            
            for (int i = 1; i <= numeroProdutos; i++)
            {
                Console.WriteLine($"Digite as informacoes do produto {i}:");
                Console.Write("Nome: ");
                nomeProduto = Console.ReadLine();
                Console.Write("Preco: R$");
                precoProduto = decimal.Parse(Console.ReadLine());
                produtos.Add(new Produto() { Nome = nomeProduto, Preco = precoProduto });

            }
            */

            Console.WriteLine("Lista original: ");
            ImprimeLista(produtos);
            Console.WriteLine();

            Console.WriteLine("Lista decrescente");
            List<Produto> produtosPorPreco = produtos.OrderByDescending(x => x.Preco).ToList();
            ImprimeLista(produtosPorPreco);
            Console.WriteLine();



            Console.WriteLine("Buscando Mouse Logitech ...");
            Console.WriteLine(VerificaMouseLogitech(produtos));
            Console.WriteLine();

            Console.WriteLine("Inserindo um elemento na posicao 5 da lista ...");
            Produto produtoP5 = new Produto("HDD IDE", 350.00M);
            Console.WriteLine(produtoP5);
            produtos.Insert(4, produtoP5);
            Console.WriteLine();

            Console.WriteLine("Lista atualizada:");
            ImprimeLista(produtos);
            Console.WriteLine();

            Console.WriteLine("Inserindo um elemento no final da lista ...");
            Produto ultimoProduto = new Produto("PC Gamer", 3000.00M);
            Console.WriteLine(ultimoProduto);
            produtos.Add(ultimoProduto);
            Console.WriteLine();

            Console.WriteLine("Lista atualizada:");
            ImprimeLista(produtos);
            Console.WriteLine();

            Console.WriteLine($"Elementos presentes na lista: {produtos.Count}");

            List<Produto> produtosComecandoComA = produtos.FindAll(x => x.Nome[0] == 'A');

            Console.WriteLine("Produtos que iniciam com A:");
            if (produtosComecandoComA.Count == 0)
            {
                Console.WriteLine("Nao ha elementos iniciando com A");
            }
            else
            {
                ImprimeLista(produtosComecandoComA);
            }
            Console.WriteLine();

            Console.WriteLine("Removendo o oitavo elemento da lista...");
            Console.WriteLine(produtos[7]);
            produtos.RemoveAt(7);
            Console.WriteLine();

            Console.WriteLine("Lista atualizada: ");
            ImprimeLista(produtos);

        }
    }
}
