// Faça um programa que leia três números e mostre o maior e o menor deles.

Console.WriteLine($"Bem-vindo ao nosso sistema de comparação de números inteiros. Informe o primeiro número: ");

int x = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe o segundo número: ");

int y = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe o terceiro número: ");

int z = int.Parse(Console.ReadLine());

if ((x > y) && (x > z) && (y > z))
{
    Console.WriteLine($"O maior número é {x} e o menor é {z}");
}
if ((x < y) && (x < z) && ( y < z))
{
    Console.WriteLine($"O maior número é {z} e o menor número é {x}");
}
if((x > y) && (x < z) && (y > z))
{
    Console.WriteLine($"O maior número é {y} e o menor número é {z}");
}
if ((x > y) && (x < z) && (y < z))
{
    Console.WriteLine($"O maior número é {z} e o menor é {y}");
}
if ((x > y) && (x > z) && ( y < z))
{
    Console.WriteLine($"O maior número é {x} e o menor número é {y}");
}
if((x < y) && (x < z) && (y > z))
{
    Console.WriteLine($"O maior número é {y} e o menor número é {x}");
}
