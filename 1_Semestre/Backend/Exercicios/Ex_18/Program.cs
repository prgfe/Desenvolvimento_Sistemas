// Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
// ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

// Informar o ano de nascimento
// Calcular a idade
// Informar o voto

Console.WriteLine($"Informe o ano de nascimento: ");
int ano = int.Parse(Console.ReadLine()!);

int data = DateTime.Now.Year;

int voto = 0;
voto = data - ano;

if (voto >= 16)
{
    Console.WriteLine($"Boa votação!");
}
else
{
    Console.WriteLine($"Espere até a idade mínima para votar.");
}