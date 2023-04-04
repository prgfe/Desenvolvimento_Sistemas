// Faça um programa que receba a idade de uma pessoa e calcule a idade em meses, dias, horas e minutos.
// Imprima o resultado no console.

Console.WriteLine($"Seja bem-vindo ao nosso sistema! Digite a sua idade em anos: ");
int idade = int.Parse(Console.ReadLine());

int converteMes = (idade * 12);

int converteDias = (idade * 365);

int converteHoras = (converteDias * 24);

int converteMin = (converteHoras * 60);

Console.WriteLine($"Sua idade é de: {idade} anos, {converteMes} meses, {converteDias} dias, {converteHoras} horas e {converteMin} minutos");
