using System;
public class Comentario
{
    public string _nome;
    public string _textoComentario;

    public Comentario(string nome, string textoComentario)
    {
        _nome = nome;
        _textoComentario = textoComentario;
    }
    public void Exibir()
    {
        Console.WriteLine(_nome);
        Console.WriteLine(_textoComentario);
    }
}
