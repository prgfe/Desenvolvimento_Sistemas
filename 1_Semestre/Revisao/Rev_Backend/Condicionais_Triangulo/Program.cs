Console.WriteLine($"Insira o primeiro lado: ");
int primeiroLado = int.Parse(Console.ReadLine());

Console.WriteLine($"Insira o segundo lado: ");
int segundoLado = int.Parse(Console.ReadLine());

Console.WriteLine($"Insira o primeiro lado: ");
int terceiroLado = int.Parse(Console.ReadLine());

if (primeiroLado == segundoLado && primeiroLado == terceiroLado)
{
    Console.WriteLine($"O triângulo é equilátero");
}
else if (primeiroLado == segundoLado || primeiroLado == terceiroLado || segundoLado == terceiroLado)
{
    Console.WriteLine($"O triângulo é isósceles");
}
else
{
    Console.WriteLine($"O triângulo é escaleno");
}