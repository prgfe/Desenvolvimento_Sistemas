// Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.

Console.WriteLine($"Digite o(s) gol(s) do time da casa: ");
int casa = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o(s) gol(s) do time visitante: ");
int visitante = int.Parse(Console.ReadLine());

if (casa > visitante)
{
    Console.WriteLine($"Vitória do time da casa.");    
}
else if (casa < visitante)
{
    Console.WriteLine($"Vitória do time visitante.");    
}
else
{
    Console.WriteLine($"Empate.");    
}