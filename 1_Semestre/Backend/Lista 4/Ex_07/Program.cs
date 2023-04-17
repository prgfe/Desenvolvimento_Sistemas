// Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos
// 15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
// declarado.

// Declarar o array 
// Informar números
// Armazenar números
// Mostrar números
// Mostrar números em ordem inversa

int[] numeros = new int[15];

for (var i = 0; i < 15; i++)
{
    Console.WriteLine($"Informe o {i+1}º número");
    numeros[i] = int.Parse(Console.ReadLine()!);
}

Console.WriteLine($"Ordem Normal: ");

for (var i = 0; i < 15; i++)
{
    Console.WriteLine($"{numeros[i]}");
}

Console.WriteLine($"");

Console.WriteLine($"Ordem inversa: ");

for (var i = 14; i >= 0; i--)
{
    Console.WriteLine($"{numeros[i]}");
}