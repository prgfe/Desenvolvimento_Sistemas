
// // Criar um programa em c# que receba 5 números inteiros e ao final exiba o seu dobro

// // Você deve utilizar a estrutura array com tamanho 5 para o armazenamento dos números, a estrutura for para a leitura dos números e a estrutura foreach para exibí-los

int[] numeros = new int[5];

for (var i = 0; i < 5; i++)
{
    Console.WriteLine($"O {i + 1}º número é: ");
    numeros[i] = int.Parse(Console.ReadLine()!);   
}

foreach (var i in numeros)
{
    Console.WriteLine(@$" 
    O dobro do {i}º número é: {i * 2}

    ");
}