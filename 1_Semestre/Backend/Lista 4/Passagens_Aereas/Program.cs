// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
// Observação :  Criar ao menos uma função (Efetuar Login).

// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).

static bool Login(string senha)
{
    if (senha == "123456")
    {
        return true;
    }
    else
    {
        return false;
    }
}

string login, senha, opcao, resposta;
bool senhaValida;
string[] nome = new string[5];
string[] origem = new string[5];
string[] destino = new string[5];
string[] data = new string[5];


Console.WriteLine($"Bem-vindo!");

Console.WriteLine($"");

Console.WriteLine($"Digite o login: ");
login = Console.ReadLine();

Console.WriteLine($"");

do
{
    Console.WriteLine($"Digite a senha: ");
    senha = Console.ReadLine();

    senhaValida = Login(senha);

} while (senhaValida != true);

Console.WriteLine($"");

do
{
Console.WriteLine($"Escolha uma opção");

Console.ForegroundColor = ConsoleColor.Blue;

Console.WriteLine(@$"
|------Menu-------|
|                 |
| [1] - Cadastrar |
| [2] - Listar    |
| [0] - Sair      |
|                 |
|-----------------|
");
opcao = Console.ReadLine();

Console.WriteLine($"Opção escolhida {opcao}");

Console.ResetColor();

Console.WriteLine($"");

switch (opcao)
{
    case "1":
    do
    {
    for (var i = 0; i < nome.Length; i++)
    {
        Console.WriteLine($"Digite o nome do passageiro: ");
        nome[i] = Console.ReadLine();
        Console.WriteLine($"Digite a origem do voo: ");
        origem[i] = Console.ReadLine().ToUpper();
        Console.WriteLine($"Digite o destino do voo: ");
        destino[i] = Console.ReadLine();
        Console.WriteLine($"Digite a data do voo (dd/mm/aaaa) :  ");
        data[i] = Console.ReadLine();
    }

    Console.WriteLine($"Gostaria de cadastrar mais passagens? (s/n)");
    resposta = Console.ReadLine().ToLower();

    } while (resposta == "s");
        break;

    case "2":
    for (var i = 0; i < nome.Length; i++)
    {
    Console.WriteLine(@$"Passagens cadastradas: 
    --------------
    Nome: {nome[i]}
    Origem: {origem[i]}
    Destino: {destino[i]}
    Data: {data[i]}
    --------------
    ");
    
    }
        break;

    case "0":
    Console.WriteLine($"Fim!");
    
        break;
    default:
    Console.WriteLine($"Escolha uma opção válida!");
        break;
}

} while (opcao != "0");