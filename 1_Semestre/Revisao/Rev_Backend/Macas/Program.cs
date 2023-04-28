// As    maçãs custam R$ 0,30 cada se forem compradas    menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor    total    da compra.

using System.Globalization; //Caixa de ferramenta global

Console.WriteLine($"Digite a quantidade de maçãs compradas: ");
int quantidade = int.Parse(Console.ReadLine());

if (quantidade < 12)
{
    float calc = quantidade * 0.30f;
    Console.WriteLine($"Total da compra {calc.ToString("C",new CultureInfo("pt-BR"))}"); // .ToString() método para determinar quantidade de casas decimais e new CultureInfo("pt-BR") indica a moeda do país desejado, no caso Brasil
}
else if (quantidade >= 12)
{
    float calc = quantidade * 0.25f;
    Console.WriteLine($"Total da compra {calc.ToString("C",new CultureInfo("pt-BR"))}");  
}