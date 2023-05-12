// Pesquise como funciona o algoritmo Fibonacci.
// Faça um programa que gere a série até que o valor seja maior que 500. 

Console.WriteLine($"Sequência de Fibonacci");

int x = 1, y = 0;

for (var z = 0; z < 502; z++)
{
    z = x + y;
    Console.WriteLine($"{z}");
    y = x;
    x = z;
}