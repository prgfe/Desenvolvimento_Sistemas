// Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
// menor valor lido.

// Informar 10 valores
// Armazenar 10 valores

// Analisar maior valor
// Analisar menor valor

// Mostrar maior e menor valores

int maior = 0, num = 0, menor;

for (var i = 0; i < 4; i++)
{
    Console.WriteLine($"Informe o {i+1}º número");
    num = int.Parse(Console.ReadLine()!);
    maior = num;
    menor = num;
}
if (num > maior)
{
    maior = num;
}
else if (num < menor)
{
    menor = num;
}

Console.WriteLine($"O maior valor é {maior} e o menor valor é {menor}");
