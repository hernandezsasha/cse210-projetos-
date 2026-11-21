using System;
using System.Collections.Generic;

public class Video
{
    public string _titulo;
    public string _autor;
    public int _duracao;
    public List<Comentario> _comentarios = new List<Comentario>();
    public void Exibir()
    {
        Console.WriteLine("Título: " + _titulo);
        Console.WriteLine("Autor: " + _autor);
        Console.WriteLine("Duração: " + _duracao + " segundos");
        Console.WriteLine("Quantidade de comentários: " + ContarComentarios());

        foreach (Comentario comentario in _comentarios)
        {
            comentario.Exibir();
        }

        Console.WriteLine("----------------------");

    }

    public Video(string titulo, string autor, int duracao)
    {
        _titulo = titulo;
        _autor = autor;
        _duracao = duracao;
    }
    public int ContarComentarios()
    {
        return _comentarios.Count;
    }
}



