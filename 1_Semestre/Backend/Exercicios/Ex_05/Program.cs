// As    maçãs custam R$ 0,30 cada se forem compradas    menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor    total    da compra.

Console.WriteLine($"Bem-vindo ao nosso sistema de compra de maçãs. Informe a quantidade de maçãs compradas: ");

int macas = int.Parse(Console.ReadLine());

if (macas < 12)
{
    double total = macas * 0.30d;
    Console.WriteLine($"Total da compra: {total}");
}
else if (macas >= 12)
{
    double total = macas * 0.25d;
    Console.WriteLine($"Total da compra: {total}");
}
