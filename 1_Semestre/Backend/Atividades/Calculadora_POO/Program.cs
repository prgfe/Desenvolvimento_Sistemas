// Crie uma classe Calculadora;
// Criar um método para cada uma das operações matemáticas(retornar float);
// Fazer o menu de opções;
// Solicitar a entrada de 2 números para o cálculo e exiba o resultado do cálculo no console.

using Calculadora_POO;

Calculadora calc = new Calculadora();

Console.WriteLine($"Digite o primeiro número: ");
calc.num1 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o segundo número: ");
calc.num2 = float.Parse(Console.ReadLine()!);

Console.WriteLine(@$"Digite a operação desejada: 
(+) soma
(-) subtração
(*) multiplicação
(/) divisão
(s) sair
");

string operacao = (Console.ReadLine()!.ToLower());

switch (operacao)
{
    case "+":
    Console.WriteLine($"O resultado é igual a {calc.Somar()}");
        break;

    case "-":
    Console.WriteLine($"O resultado é igual a {calc.Subtrair()}");
        break;

    case "*":
    Console.WriteLine($"O resultado é igual a {calc.Multiplicar()}");
        break;

    case "/":
    Console.WriteLine($"O resultado é igual a {calc.Dividir()}");
    break;

    case "s":
    Console.WriteLine($"Programa finalizado com sucesso!");
        break;

    default:
    Console.WriteLine($"Operação inválida. Repita o processo.");
        break;
}