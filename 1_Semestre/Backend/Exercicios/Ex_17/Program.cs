// Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.

// Exemplo: tabuada do 1, tabuada do 2, etc...
// Dica: utilize um laço dentro do outro.

Console.WriteLine($"Programa de tabuada.");

for (var i = 1; i <= 10; i++)
{
    Console.WriteLine($"Tabuada do {i}");
    
    for (var num = 1; num <= 10; num++)
    {
    Console.WriteLine($"{num} x {i} = {num * i}");
    }
}
