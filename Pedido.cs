using System;
using System.Collections.Generic;

namespace MaquiagemApp
{
    public class Pedido
    {
        public Cliente Cliente { get; set; }
        public List<ProdutoMaquiagem> Produtos { get; set; }

        public Pedido(Cliente cliente)
        {
            Cliente = cliente;
            Produtos = new List<ProdutoMaquiagem>();
        }

        public void AdicionarProduto(ProdutoMaquiagem produto)
        {
            Produtos.Add(produto);
        }

        public double CalcularTotal()
        {
            double total = 0;
            foreach (var produto in Produtos)
            {
                total += produto.Preco;
            }
            return total;
        }

        public void ExibirPedido()
        {
            Console.WriteLine("=== Pedido ===");
            Cliente.ExibirCliente();

            Console.WriteLine("\nProdutos:");
            foreach (var produto in Produtos)
            {
                produto.ExibirInfo();
                Console.WriteLine();
            }

            Console.WriteLine($"Total: R$ {CalcularTotal()}");
        }
    }
}