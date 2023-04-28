// Faça um programa que receba o ano do nascimento de uma pessoa e calcule a idade dessa pessoa em anos
// e semanas e imprima o resultado no console.

Console.WriteLine($"Digite seu ano de nascimento: ");
int nascimento = int.Parse(Console.ReadLine());

int ano = DateTime.Now.Year - nascimento;
int semana = ano * 54;

Console.WriteLine($"Sua idade em anos é {ano} anos ou {semana} semanas");