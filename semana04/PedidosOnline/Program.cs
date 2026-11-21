using System;

class Program
{
    static void Main(string[] args)
    {
       
        Endereco endereco1 = new Endereco(
            "123 Main Street",
            "New York",
            "New York",
            "USA"
        );

        Cliente cliente1 = new Cliente("Maria", endereco1);

        
        Produto produto1 = new Produto("Notebook", "P001", 500, 1);
        Produto produto2 = new Produto("Mouse", "P002", 25, 2);

        Pedido pedido1 = new Pedido(cliente1);

        pedido1.AdicionarProduto(produto1);
        pedido1.AdicionarProduto(produto2);

        
        Endereco endereco2 = new Endereco(
            "Rua das Flores",
            "Cascavel",
            "Parana",
            "Brasil"
        );

        Cliente cliente2 = new Cliente("Carlos", endereco2);

        
        Produto produto3 = new Produto("Teclado", "P003", 40, 1);
        Produto produto4 = new Produto("Monitor", "P004", 200, 2);
        Produto produto5 = new Produto("Fone", "P005", 30, 1);

        Pedido pedido2 = new Pedido(cliente2);

        pedido2.AdicionarProduto(produto3);
        pedido2.AdicionarProduto(produto4);
        pedido2.AdicionarProduto(produto5);

        
        Console.WriteLine("========== PEDIDO 1 ==========");

        Console.WriteLine(pedido1.GerarEtiquetaEmbalagem());
        Console.WriteLine(pedido1.GerarEtiquetaEnvio());

        Console.WriteLine("Total: $" + pedido1.CalcularTotal().ToString("F2"));

        
        Console.WriteLine("\n========== PEDIDO 2 ==========");

        Console.WriteLine(pedido2.GerarEtiquetaEmbalagem());
        Console.WriteLine(pedido2.GerarEtiquetaEnvio());

        Console.WriteLine("Total: $" + pedido2.CalcularTotal().ToString("F2"));
    }
}