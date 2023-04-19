// Projeto para gerenciamento de 10 produtos pelo console:
// Os produtos terão os seguintes atributos:
// string Nome
// float Preco
// bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:
// CadastrarProduto
// ListarProdutos
// MostrarMenu
// Crie função(ões) para otimizar o código.
// Incremente o que achar necessário. Utilize sua lógica e sua criatividade.

string senha, login, escolha;
bool senhaValida;
string[] nome = new string[10];
float[] preco = new float[10];
bool[] promo = new bool[10];

bool saldao = false;

static bool Login(string senha)
{
    if (senha == "123456")
    {
        Console.WriteLine($"Acesso liberado!");
        return true;
    }
    else
    {
        Console.WriteLine($"Senha inválida!");
        return false;
    }
}

Console.WriteLine($"Bem-vindo!");

Console.WriteLine($"");

Console.Write($"Login: ");

login = Console.ReadLine()!;

do
{
    Console.Write($"Senha: ");
    senha = Console.ReadLine()!;

    senhaValida = Login(senha);
    
} while (senhaValida != true);

do
{
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@$"
%%%%%%%%%.Menu.%%%%%%%%%%
%     [1] Cadastrar     %
%     [2] Listar        %
%     [3] Sair          %
%%%%%%%%%%%%%%%%%%%%%%%%%
");
escolha = Console.ReadLine()!;

Console.ResetColor();

switch (escolha)
{
    case "1":
        for (var i = 0; i < nome.Length; i++)
        {
            Console.WriteLine($"Nome do produto: ");
            nome[i] = Console.ReadLine()!;

            Console.WriteLine($"Preço do produto: ");
            preco[i] = float.Parse(Console.ReadLine()!);

            Console.WriteLine($"Está em promoção? (s/n)");            
            promo[i] = bool.Parse(Console.ReadLine()!);     

            if (promo[i] == true)
            {
                Console.WriteLine($"Em promoção");                                
            } 
            else
            {
                Console.WriteLine($"Em promoção");                               
            }       
        }
    
        break;

    case "2":
        for (var i = 0; i < nome.Length; i++)
        {
            Console.WriteLine(@$"
            ****Estoque****
            Nome: {nome[i]} 
            Preço: {preco[i]}
            Promoção: {promo[i]}
            ");
        }
        break;

    case "3":
    Console.WriteLine($"Fim!");
    
        break;

    default:
    Console.WriteLine($"Digite uma opção válida!");
        break;
}

} while (escolha != "3");