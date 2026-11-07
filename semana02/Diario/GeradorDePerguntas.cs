using System;
using System.Collections.Generic;

public class GeradorDePerguntas
{
    private List<string> _perguntas = new List<string>
    {
        "O que você fez hoje?",
        "O que te deixou feliz hoje?",
        "Qual foi seu maior desafio hoje?",
        "O que você aprendeu hoje?",
        "Pelo que você é grato hoje?"
    };

    public string ObterPerguntaAleatoria()
    {
        Random aleatorio = new Random();
        int numero = aleatorio.Next(_perguntas.Count);
        return _perguntas[numero];
    }
}