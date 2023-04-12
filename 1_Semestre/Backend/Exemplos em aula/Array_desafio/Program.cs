// DESAFIOS
// Faça um programa que carregue um array de tamanho 6 com números inteiros. Calcule e imprima a quantidade de números ímpares e a quantidade de números pares.

// ALGORITMO

// array do tipo inteiro e tamanho 6

// calcular resto: se 0, é par, se não, é ímpar

// imprimir qtde de pares e ímpares

int[] num = new int[6];
int par = 0, impar = 0;

for (var i = 0; i < 6; i++)
{
    Console.WriteLine($"Informe o {i + 1}º número: ");
    num[i] = int.Parse(Console.ReadLine()!);

    if (num[i] % 2 == 0)
    {
        par++;        
    }
    else
    {
        impar++;
    }
}

Console.WriteLine($"{par} números pares e {impar} números ímpares");
