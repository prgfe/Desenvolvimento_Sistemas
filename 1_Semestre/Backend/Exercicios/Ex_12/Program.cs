// Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.

Console.WriteLine($"Informe uma nota entre zero e dez: ");
float nota = float.Parse(Console.ReadLine()!);

while ((nota < 0) || (nota > 10))
{
    Console.WriteLine($"Informe uma nota entre zero e dez!");
    nota = float.Parse(Console.ReadLine()!);
}

