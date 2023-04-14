// Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.
// Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.

// calcular tabuada 1
// 

for (var i = 1; i < 11; i++)
{
    Console.WriteLine($"Tabuada do {i}");
    for (var x = 1; x < 11; x++)
    {
        Console.WriteLine($"{i} x {x} = {i * x}");
    }
}