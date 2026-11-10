using System;

class Program
{
    static void Main(string[] args)
    {
        Fracao fracao1 = new Fracao();

        Fracao fracao2 = new Fracao(5);

        Fracao fracao3 = new Fracao(6, 7);

        Fracao fracao4 = new Fracao(1, 3);

        fracao3.DefinirNumerador(3);
        fracao3.DefinirDenominador(4);

        Console.WriteLine(fracao3.ObterNumerador());
        Console.WriteLine(fracao3.ObterDenominador());

        Console.WriteLine(fracao1.ObterFracaoEmTexto());
        Console.WriteLine(fracao1.ObterFracaoEmDecimal());

        Console.WriteLine(fracao2.ObterFracaoEmTexto());
        Console.WriteLine(fracao2.ObterFracaoEmDecimal());

        Console.WriteLine(fracao3.ObterFracaoEmTexto());
        Console.WriteLine(fracao3.ObterFracaoEmDecimal()); 

        Console.WriteLine(fracao4.ObterFracaoEmTexto());
        Console.WriteLine(fracao4.ObterFracaoEmDecimal());
    }

}