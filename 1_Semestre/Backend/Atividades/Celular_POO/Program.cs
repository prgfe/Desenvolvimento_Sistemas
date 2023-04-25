// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.

using Celular_POO;

Celular novoCelular = new Celular();

Console.WriteLine($"Digite a cor: ");
novoCelular.Cor = Console.ReadLine();

Console.WriteLine($"Digite o modelo: ");
novoCelular.Modelo = Console.ReadLine();

Console.WriteLine($"Digite o tamanho: ");
novoCelular.Tamanho = Console.ReadLine();

Console.WriteLine($"O celular está ligado? s/n ");
string ligado = Console.ReadLine().ToLower();

novoCelular.Ligado = ligado == "s" ? true : false;

novoCelular.Ligado = true;

string opcao;

if (ligado == "s")
{
    do
    {
        Console.WriteLine($"Menu");
        Console.WriteLine(@$"
    [1] Fazer ligação
    [2] Enviar mensagem
    [3] Desligar
    ");

        opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                novoCelular.Ligacao();
                break;
            case "2":
                novoCelular.Mensagem();
                break;
            case "3":
                novoCelular.Desligar();
                break;
            default:
                Console.WriteLine($"Escolha uma opção válida!");
                break;
        }
    } while (opcao != "3");

}
else if (ligado == "n")
{
    Console.WriteLine($"Celular desligado.");
    Console.WriteLine($"Quer ligar o celular? s/n");
    string poweron = Console.ReadLine();
    if (poweron == "s")
    {
        novoCelular.Ligar();
        do
        {
            Console.WriteLine($"Menu");
            Console.WriteLine(@$"
        [1] Fazer ligação
        [2] Enviar mensagem
        [3] Desligar
    ");

            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    novoCelular.Ligacao();
                    break;
                case "2":
                    novoCelular.Mensagem();
                    break;
                case "3":
                    novoCelular.Desligar();
                    break;
                default:
                    Console.WriteLine($"Escolha uma opção válida!");
                    break;
            }
        } while (opcao != "3");
    }
    else
    {
        Console.WriteLine($"Fim.");
    }
}






