using System;

class Program
{
    static void Main(string[] args)
    {
       Random aleatorio = new Random();
        int numeroMagico = aleatorio.Next(1, 101);

        Console.Write("Qual é o seu palpite? ");
        int palpite = int.Parse(Console.ReadLine());

        while (palpite != numeroMagico)
        {
            if (palpite < numeroMagico)
            {
                Console.WriteLine("Mais alto");
            }
            else
            {
                Console.WriteLine("Mais baixo");
            }

            Console.Write("Qual é o seu palpite? ");
            palpite = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Você adivinhou!");
    }
}