Console.WriteLine($"Informe o salário recebido: ");
float salario = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o total gasto: ");
float totalGasto = float.Parse(Console.ReadLine());

if (salario >= totalGasto)
{
    Console.WriteLine($"Gastos dentro do orçamento.");
}
else
{
    Console.WriteLine($"Orçamento estourado!");
}