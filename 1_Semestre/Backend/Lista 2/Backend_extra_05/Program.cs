// Faça um programa que verifique se uma letra digitada é vogal ou consoante

Console.WriteLine($"Informe uma letra: ");

string letra = Console.ReadLine()!;

if ((letra == "a") || (letra == "e") || (letra == "i") || (letra == "o") || (letra == "u"))
{
    Console.WriteLine($"É vogal");
}
else
{
    Console.WriteLine($"É consoante"); 
}
