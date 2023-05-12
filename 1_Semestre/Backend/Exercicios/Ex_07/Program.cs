// Escreva um programa que pergunte o dia, mês e ano do aniversário de uma pessoa e diga se a data é válida ou não. Caso não seja, diga o motivo. Suponha que todos os meses tem 31 dias e que estejamos no ano de 2013.

Console.WriteLine($"Bem-vindo ao sistema de adivinhação de idade. Informe o dia de seu aniversário: ");
int dia = int.Parse(Console.ReadLine());
Console.WriteLine($"Informe o mês de seu aniversário: ");
int mes = int.Parse(Console.ReadLine());
Console.WriteLine($"Informe o ano de seu aniversário: ");
int ano = int.Parse(Console.ReadLine());

if ((dia > 0) && (dia < 32))
{
    Console.WriteLine($"Dia valido");
}
else
{
    Console.WriteLine($"Dia invalido. Existem 31 dias no mes");  
}

if ((mes > 0) && (mes < 13))
{
    Console.WriteLine($"Mes valido");
}
else
{
    Console.WriteLine($"Mes invalido. So existem 12 meses no ano. ");
}

if ((ano > 0) && (ano < 2013))
{
    Console.WriteLine($"Ano valido");
}
else
{
    Console.WriteLine($"Ano invalido. Estamos no ano de 2013.");
}

