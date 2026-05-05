using System;
using MaquiagemApp;

class Program
{
    static void Main(string[] args)
    {
        ProdutoMaquiagem p1 = new ProdutoMaquiagem("Base Líquida", "Maybelline", 59.90, "Rosto");
        ProdutoMaquiagem p2 = new ProdutoMaquiagem("Batom Matte", "MAC", 79.90, "Lábios");

        Cliente cliente = new Cliente("Ana Souza", "ana@email.com");

        Pedido pedido = new Pedido(cliente);
        pedido.AdicionarProduto(p1);
        pedido.AdicionarProduto(p2);

        pedido.ExibirPedido();

        Console.ReadLine();
    }
}