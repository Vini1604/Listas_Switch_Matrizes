﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Listas
{
    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto()
        {

        }

        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public override string ToString()
        {
            return $"Produto: {Nome} - Preco: R${Preco:F2}";
        }




    }
}
