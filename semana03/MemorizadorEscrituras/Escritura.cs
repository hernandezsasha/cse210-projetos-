using System;
using System.Collections.Generic;

public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavras;
    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;
        _palavras = new List<Palavra>();

        string[] palavras = texto.Split(' ');

        foreach (string palavra in palavras)
        {
            Palavra objetoPalavra = new Palavra(palavra);
            _palavras.Add(objetoPalavra);
        }
    }
    public void OcultarPalavrasAleatorias(int quantidade)
    {
        Random aleatorio = new Random();
        int ocultadas = 0;
        int visibles = 0;

        foreach (Palavra palavra in _palavras)
        {
            if (palavra.EstaOculta() == false)
            {
                visibles++;
            }
        }

        while (ocultadas < quantidade && visibles > 0)
        {
            int indice = aleatorio.Next(_palavras.Count);

            if (_palavras[indice].EstaOculta() == false)
            {
                _palavras[indice].Ocultar();
                ocultadas++;
                visibles--;
            }
        }
    }
    public string ObterTexto()
    {
        string texto = _referencia.ObterTexto() + " ";

        foreach (Palavra palavra in _palavras)
        {
            texto += palavra.ObterTexto() + " ";
        }

        return texto.Trim();

    }
    public bool EstaCompleta()
    {
        foreach (Palavra palavra in _palavras)
        {
            if (palavra.EstaOculta() == false)
            {
                return false;
            }
        }

        return true;
    }
}
