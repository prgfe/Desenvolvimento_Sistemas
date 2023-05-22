Console.WriteLine($"Insira um número inteiro: ");
int inteiro = int.Parse(Console.ReadLine());

for (var i = 1; i < 11; i++)
{
    Console.WriteLine($"{inteiro} x {i} = {inteiro * i}");
}