using Listas;
using System;
using System.Collections.Generic;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            //FIZ UMA REFERENCIA DA CLASSE PRODUTO DO PROJETO LISTAS
            
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

            int indice;

            Console.WriteLine("Digite o indice para buscar um elemento da lista");
            indice = int.Parse(Console.ReadLine());

            switch (indice)
            {
                case 1:
                    Console.WriteLine(produtos[indice]);
                    break;
                case 2:
                    Console.WriteLine(produtos[indice]);
                    break;
                case 3:
                    Console.WriteLine(produtos[indice]);
                    break;
                case 4:
                    Console.WriteLine(produtos[indice]);
                    break;
                case 5:
                    Console.WriteLine(produtos[indice]);
                    break;
                default:
                    Console.WriteLine("Nao foi possivel acessar a lista");
                    break;
            }
        }
    }
}
