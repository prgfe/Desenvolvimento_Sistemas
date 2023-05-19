Console.WriteLine($"Digite uma letra: ");
string letra = Console.ReadLine();

if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
{
    Console.WriteLine($"É vogal.");
}
else
{
    Console.WriteLine($"É consoante.");
}