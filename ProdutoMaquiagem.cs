using System;

namespace MaquiagemApp
{
    public class ProdutoMaquiagem
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public double Preco { get; set; }
        public string Categoria { get; set; }

        public ProdutoMaquiagem(string nome, string marca, double preco, string categoria)
        {
            Nome = nome;
            Marca = marca;
            Preco = preco;
            Categoria = categoria;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Produto: {Nome}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Preço: R$ {Preco}");
            Console.WriteLine($"Categoria: {Categoria}");
        }
    }
}