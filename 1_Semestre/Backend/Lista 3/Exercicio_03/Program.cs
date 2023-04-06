// Faça um programa que receba um número inteiro e mostre a sua tabuada.

Console.WriteLine($"Informe um numero inteiro: ");
int num = int.Parse(Console.ReadLine());

for (int x = 1; x <= 10; x++)
{   
    Console.WriteLine($"{num} x {x} = {num * x}");
}
