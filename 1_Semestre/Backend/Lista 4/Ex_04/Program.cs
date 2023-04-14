// Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
// menor valor lido.

// Informar 10 valores
// Armazenar 10 valores

// Analisar maior valor
// Analisar menor valor

// Mostrar maior e menor valores

int[] num = new int[10];
Array.Sort(num);

for (var i = 0; i < 10; i++)
{
Console.WriteLine($"Insira o {i + 1}º numero");
num[i] = int.Parse(Console.ReadLine()!);
}

Console.WriteLine($"Menor {num.Min()} e maior {num.Max()}");