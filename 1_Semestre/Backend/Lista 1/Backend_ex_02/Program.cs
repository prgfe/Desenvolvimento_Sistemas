// Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.

Console.WriteLine($"Bem-vindo ao nosso sistema! Informe o placar do time1: ");

int time1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe o placar do time2: ");

int time2 = int.Parse(Console.ReadLine());

if (time1 > time2)
{
    Console.WriteLine($"Vitória do time1");
}

else if (time1 == time2)
{
    Console.WriteLine($"Empate");
}

else 
{
    Console.WriteLine($"Vitória do time2");
}