// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
// Observação :  Criar ao menos uma função (Efetuar Login).

// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).

// Login

// Menu

// para 5 passageiros
// cadastrar 
// nome
// origem
// destino
// data do voo (dia, mes, ano)

// Listar passagens

Console.WriteLine($"Bem-vindo(a) ao sistema de cadastramento de passagens aéreas!");

Console.WriteLine($"Informe o nome de usuário: ");
string user = Console.ReadLine()!;

Console.WriteLine($"Informe a senha: ");
int senha = int.Parse(Console.ReadLine()!);

while (senha != 654321)
{
    Console.WriteLine($"Acesso negado! Tente novamente.");
}