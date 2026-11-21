using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();

        Video video1 = new Video("Música", "Ana", 120);
        Video video2 = new Video("Esporte", "Luis", 60);
        Video video3 = new Video("Cozinha", "Lucia", 150);
        Video video4 = new Video("Infantis", "Luisa", 30);

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        Comentario comentario1 = new Comentario("Sofia", "Muito boa a letra");
        Comentario comentario2 = new Comentario("Maria", "Gostei muito");
        Comentario comentario3 = new Comentario("Jose", "Excelente música");

        video1._comentarios.Add(comentario1);
        video1._comentarios.Add(comentario2);
        video1._comentarios.Add(comentario3);

        Comentario comentario4 = new Comentario("Angel", "Muito bom o jogo");
        Comentario comentario5 = new Comentario("Roberto", "foi incrível");
        Comentario comentario6 = new Comentario("Serafina", "Gostei");
        Comentario comentario7 = new Comentario("Luciana", "Excelente");

        video2._comentarios.Add(comentario4);
        video2._comentarios.Add(comentario5);
        video2._comentarios.Add(comentario6);
        video2._comentarios.Add(comentario7);


        Comentario comentario8 = new Comentario("Miguel", "Que boa receita");
        Comentario comentario9 = new Comentario("Edson", "Que gostoso");
        Comentario comentario10 = new Comentario("Mauricio", "Já quero experimentar");
        Comentario comentario11 = new Comentario("Sabrina", "vou fazer em casa");

        video3._comentarios.Add(comentario8);
        video3._comentarios.Add(comentario9);
        video3._comentarios.Add(comentario10);
        video3._comentarios.Add(comentario11);


        Comentario comentario12 = new Comentario("Eidhen", "Que divertido");
        Comentario comentario13 = new Comentario("Elio", "Meu filho amou");
        Comentario comentario14 = new Comentario("Helamã", "Deixa boas ensinanzas");
        Comentario comentario15 = new Comentario("Carla", "Meu filho gosta dos videos");

        video4._comentarios.Add(comentario12);
        video4._comentarios.Add(comentario13);
        video4._comentarios.Add(comentario14);
        video4._comentarios.Add(comentario15);


        foreach (Video video in videos)
        {
            video.Exibir();
        }

    }
}