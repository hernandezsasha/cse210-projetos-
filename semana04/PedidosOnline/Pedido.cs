using System;
using System.Collections.Generic;

public class Pedido
{
    private List<Produto> _produtos;
    private Cliente _cliente;

    public Pedido(Cliente cliente)
    {
        _cliente = cliente;
        _produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        _produtos.Add(produto);
    }

    public double CalcularTotal()
    {
        double total = 0;

        foreach (Produto produto in _produtos)
        {
            total += produto.CalcularTotal();
        }

        if (_cliente.MoraNosEUA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GerarEtiquetaEmbalagem()
    {
        string etiqueta = "ETIQUETA DE EMBALAGEM\n";

        foreach (Produto produto in _produtos)
        {
            etiqueta += "Produto: " + produto.GetNome() + "\n";
            etiqueta += "ID: " + produto.GetIdProduto() + "\n";
        }

        return etiqueta;
    }

    public string GerarEtiquetaEnvio()
    {
        string etiqueta = "ETIQUETA DE ENVIO\n";

        etiqueta += "Cliente: " + _cliente.GetNome() + "\n";
        etiqueta += _cliente.GetEndereco().FormatarEndereco();

        return etiqueta;
    }
}