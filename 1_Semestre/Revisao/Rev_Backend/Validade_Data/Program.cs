// Escreva um programa que pergunte o dia, mês e ano do aniversário de uma pessoa e diga se a data é válida ou não. Caso não seja, diga o motivo. Suponha que todos os meses tem 31 dias e que estejamos no ano de 2013.

Console.WriteLine($"Digite dia do seu aniversário: ");
int dia = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite mês do seu aniversário: ");
int mes = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite ano do seu aniversário: ");
int ano = int.Parse(Console.ReadLine());

if ((dia > 0) && (dia < 32))
{
    Console.WriteLine($"Dia válido");
}
else
{
    Console.WriteLine($"Dia inválido");
}

if ((mes > 0) && (mes < 13))
{
    Console.WriteLine($"Mês válido");
}
else
{
    Console.WriteLine($"Mês inválido");
}

if ((ano < 2013) && (ano > 1900))
{
    Console.WriteLine($"Ano válido");
}
else
{
    Console.WriteLine($"Ano inválido");
}