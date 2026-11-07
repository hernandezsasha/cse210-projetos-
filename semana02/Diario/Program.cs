using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    // Funcionalidade extra: mostrar a quantidade total de registros do diario.
    {
        Diario diario = new Diario();
        GeradorDePerguntas gerador = new GeradorDePerguntas();

        string opcao = "";

        while (opcao != "6")
        {
            Console.WriteLine("\n===== MEU DIARIO =====");
            Console.WriteLine("1. Nova entrada");
            Console.WriteLine("2. Exibir diario");
            Console.WriteLine("3. Salvar diario");
            Console.WriteLine("4. Carregar diario");
            Console.WriteLine("5. Mostrar quantidade de registros");
            Console.WriteLine("6. Sair");
            Console.Write("Escolha uma opcao: ");

            opcao = Console.ReadLine();

            if (opcao == "1")
            {
                Registro registro = new Registro();

                registro._data = DateTime.Now.ToShortDateString();
                registro._textoPergunta = gerador.ObterPerguntaAleatoria();

                Console.WriteLine(registro._textoPergunta);
                registro._textoResposta = Console.ReadLine();

                diario.AdicionarRegistro(registro);
            }
            else if (opcao == "2")
            {
                diario.ExibirTodos();
            }
            else if (opcao == "3")
            {
                Console.Write("Nome do arquivo: ");
                string arquivo = Console.ReadLine();
                diario.SalvarNoArquivo(arquivo);
                Console.WriteLine("Diario salvo!");
            }
            else if (opcao == "4")
            {
                Console.Write("Nome do arquivo: ");
                string arquivo = Console.ReadLine();
                diario.CarregarDoArquivo(arquivo);
                Console.WriteLine("Diario carregado!");
            }
            else if (opcao == "5")
            {
                diario.ExibirQuantidade();
            }
            else if (opcao == "6s")
            {
                Console.WriteLine("Ate logo!");
            }
            else
            {
                Console.WriteLine("Opcao invalida.");
            }
        }
    }
}