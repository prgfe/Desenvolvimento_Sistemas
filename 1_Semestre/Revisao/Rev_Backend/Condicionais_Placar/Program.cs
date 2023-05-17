Console.WriteLine($"Insira o número de gols do primeiro time: ");
int primeiroTime = int.Parse(Console.ReadLine());

Console.WriteLine($"Insira o número de gols do segundo time: ");
int segundoTime = int.Parse(Console.ReadLine());

if (primeiroTime > segundoTime)
{
    Console.WriteLine($"Vitória do primeiro time.");
}
else if (primeiroTime < segundoTime)
{
    Console.WriteLine($"Vitória do segundo time.");
}
else
{
    Console.WriteLine($"Empate.");
}