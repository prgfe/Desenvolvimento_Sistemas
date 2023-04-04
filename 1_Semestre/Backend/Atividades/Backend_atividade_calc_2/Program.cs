// Faça um programa que receba o ano do nascimento de uma pessoa e calcule a idade dessa pessoa em anos
// em semanas e imprima o resultado no console.

Console.WriteLine($"Olá! Bem-vindo ao nosso sistema! Digite a sua idade: ");

int idade = int.Parse(Console.ReadLine());

var data = DateTime.Now.Year;

int anoNasc = data - idade - 1;

Console.WriteLine($"Seu ano de nascimento é {anoNasc}");

int idadeSem = idade * 54;

Console.WriteLine($"Sua idade é de {idadeSem} semanas");