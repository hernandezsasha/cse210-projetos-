using System;

public class Fracao
{
    private int _numerador;
    private int _denominador;

    public Fracao(int numeradorInicial, int denominadorInicial)
    {
        _numerador = numeradorInicial;
        _denominador = denominadorInicial;
    }

    public Fracao(int numeradorInicial)
    {
        _numerador = numeradorInicial;
        _denominador = 1;
    }

    public Fracao()
    {
        _numerador = 1;
        _denominador = 1;
    }

    public string ObterFracaoEmTexto()
    {
        return _numerador + "/" + _denominador;
    }

    public double ObterFracaoEmDecimal()
    {
        return (double)_numerador / _denominador;
    }

    public int ObterNumerador()
    {
        return _numerador;
    }

    public void DefinirNumerador(int novoNumerador)
    {
        _numerador = novoNumerador;
    }

    public int ObterDenominador()
    {
        return _denominador;
    }

    public void DefinirDenominador(int novoDenominador)
    {
        _denominador = novoDenominador;
    }
}



