using System;

public class Produto
{
    private string _nomeProduto;
    private string _idProduto;
    private double _precoProduto;
    private int _quantidade;

    public Produto(string nomeProduto, string idProduto, double precoProduto, int quantidade)
    {
        _nomeProduto = nomeProduto;
        _idProduto = idProduto;
        _precoProduto = precoProduto;
        _quantidade = quantidade;
    }

    public string GetNome()
    {
        return _nomeProduto;
    }

    public string GetIdProduto()
    {
        return _idProduto;
    }

    public double GetPrecoProduto()
    {
        return _precoProduto;
    }

    public int GetQuantidade()
    {
        return _quantidade;
    }

    public void SetNomeProduto(string nomeProduto)
    {
        _nomeProduto = nomeProduto;
    }

    public void SetPrecoProduto(double precoProduto)
    {
        _precoProduto = precoProduto;
    }

    public void SetQuantidade(int quantidade)
    {
        _quantidade = quantidade;
    }

    public double CalcularTotal()
    {
        return _precoProduto * _quantidade;
    }
    
}