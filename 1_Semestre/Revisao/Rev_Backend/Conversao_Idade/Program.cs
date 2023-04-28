// Faça um programa que receba a idade de uma pessoa e calcule a idade em meses, dias, horas e minutos.
// Imprima o resultado no console.

Console.WriteLine($"Digite a sua idade: ");
int idade = int.Parse(Console.ReadLine());

int mes = idade * 12;
int dia = mes * 30;
int hora = dia * 24;
int min = hora * 60;

Console.WriteLine($"A sua idade é: {idade} anos ou {mes} meses ou {dia} dias ou {hora} horas ou {min} minutos.");