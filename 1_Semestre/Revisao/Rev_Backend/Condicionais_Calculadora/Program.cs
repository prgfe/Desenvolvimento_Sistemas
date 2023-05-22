string opcao;

Console.WriteLine(@$"Informe a operação desejada:
[1] Soma
[2] Subtração
[3] Multiplicação
[4] Divisão
");
opcao = Console.ReadLine();

Console.WriteLine($"Informe o primeiro valor: ");
float num1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o segundo valor: ");
float num2 = float.Parse(Console.ReadLine());

float resultado = 0;

switch (opcao)
{
    case "1":
        resultado = num1 + num2;
        Console.WriteLine($"O resultado é {resultado}");
        break;
    case "2":
        resultado = num1 - num2;
        Console.WriteLine($"O resultado é {resultado}");
        break;
    case "3":
        resultado = num1 * num2;
        Console.WriteLine($"O resultado é {resultado}");
        break;
    case "4":
        resultado = num1 / num2;
        Console.WriteLine($"O resultado é {resultado}");
        break;
    default:
        Console.WriteLine($"Escolha uma opção válida!");
        break;
}

