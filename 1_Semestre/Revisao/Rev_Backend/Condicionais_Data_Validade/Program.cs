Console.WriteLine($"Informe o dia do aniversário: ");
int diaAniversario = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe o mês do aniversário: ");
int mesAniversario = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe o ano do aniversário: ");
int anoAniversario = int.Parse(Console.ReadLine());

if (diaAniversario < 32 && diaAniversario > 0)
{
    Console.WriteLine($"Dia válido.");
}
else
{
    Console.WriteLine($"Data incorreta. Dia inválido.");
    System.Environment.Exit(0);
}
if (mesAniversario < 13 && mesAniversario > 0)
{
    Console.WriteLine($"Mês válido.");
}
else
{
    Console.WriteLine($"Data inválida. Mês inválido.");
    System.Environment.Exit(0);
}
if (anoAniversario < 2014 && anoAniversario > 1899)
{
    Console.WriteLine($"Ano válido");
}
else
{
    Console.WriteLine($"Data inválida. Ano inválido.");
    System.Environment.Exit(0);
}