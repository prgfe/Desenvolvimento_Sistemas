float nota;
do
{
    Console.WriteLine($"Insira uma nota de zero a dez: ");
    nota = float.Parse(Console.ReadLine());
    if (nota < 0 || nota > 10)
    {
        Console.WriteLine($"Insira uma nota válida.");
    }
} while (nota < 0 || nota > 10);
