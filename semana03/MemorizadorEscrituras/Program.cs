using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Melhoria adicional: o programa carrega uma biblioteca de escrituras
        // de um arquivo externo e seleciona uma escritura aleatoriamente
        // sempre que o programa é iniciado.
        string[] linhas = File.ReadAllLines("escrituras.txt");

        Random aleatorio = new Random();

        int indice = aleatorio.Next(linhas.Length);

        string[] dados = linhas[indice].Split('|');

        Referencia referencia = new Referencia(
            dados[0],
            int.Parse(dados[1]),
            int.Parse(dados[2]),
            int.Parse(dados[3])
        );

        string texto = dados[4];

        Escritura escritura = new Escritura(referencia, texto);

        while (true)
        {
            Console.Clear();

            Console.WriteLine(escritura.ObterTexto());

            Console.WriteLine("Pressione Enter para continuar ou digite 'sair' para sair:");

            string entrada = Console.ReadLine();

            if (entrada.ToLower() == "sair")
            {
                break;
            }

            if (escritura.EstaCompleta())
            {
                break;
            }

            escritura.OcultarPalavrasAleatorias(1);
        }


    }
}
