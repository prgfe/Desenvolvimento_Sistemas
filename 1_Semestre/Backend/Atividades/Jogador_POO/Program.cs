using Jogador_POO;

JOGADORDEFESA defesa = new JOGADORDEFESA();
JOGADORMEIOCAMPO meioCampo = new JOGADORMEIOCAMPO();
JOGADORATAQUE ataque = new JOGADORATAQUE();

string opcao;

do
{
    Console.WriteLine(@$"Selecione a posição do jogador:
[1] Defesa
[2] Meio Campo
[3] Ataque
[0] Sair
");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            defesa.Pergunta();
            defesa.Dados();
            defesa.Defesa();
            break;
        case "2":
            meioCampo.Pergunta();
            meioCampo.Dados();
            meioCampo.MeioCampo();
            break;
        case "3":
            ataque.Pergunta();
            ataque.Dados();
            ataque.Ataque();
            break;
        case "0":
            Console.WriteLine($"Saindo do programa...");
            break;
        default:
            Console.WriteLine($"Insira uma opcao válida.");

            break;
    }
} while (opcao != "0");

