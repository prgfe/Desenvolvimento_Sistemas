Console.WriteLine($"Insira o primeiro valor: ");
int primeiroValor = int.Parse(Console.ReadLine());

Console.WriteLine($"Insira o segundo valor: ");
int segundoValor = int.Parse(Console.ReadLine());

Console.WriteLine($"Insira o terceiro valor: ");
int terceiroValor = int.Parse(Console.ReadLine());

Console.WriteLine($"Maior número {Math.Max(primeiroValor, Math.Max(segundoValor, terceiroValor))}");
Console.WriteLine($"Menor número {Math.Min(primeiroValor, Math.Min(segundoValor, terceiroValor))}");