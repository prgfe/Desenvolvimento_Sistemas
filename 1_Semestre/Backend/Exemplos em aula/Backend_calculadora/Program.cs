// calculadora

// algoritmo

// 1.informar a operacao
// 2.informar o primeiro numero
// 3.informar o segundo numero
// 4.processar os dados
// 5.exibir o resultado

// ENTRADA

Console.WriteLine(@$"
-------------------------
|Programa de calculadora|
|    Informe a operacao:|
|                       |
|   (+) soma            |
|   (-) subtracao       |
|   (*) multiplicacao   |
|   (/) divisao         |
-------------------------
");

char operacao = char.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o primeiro numero:");

double num1 = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o segundo numero:");

double num2 = double.Parse(Console.ReadLine()!);

double resultado = 0;

// PROCESSAMENTO E SAIDA

switch (operacao)
{
    case '+':
        resultado = (num1 + num2);
        Console.WriteLine($"O resultado e igual a {resultado}");
        
        break;
    case '-':
        resultado = (num1 - num2);
        Console.WriteLine($"O resultado e igual a {resultado}");
        
        break;
    case '*':
        resultado = (num1 * num2);
        Console.WriteLine($"O resultado e igual a {resultado}");
        
        break;
    case '/':
        resultado = (num1 / num2);
        Console.WriteLine($"O resultado e igual a {resultado}");
        
        break;
    default:
    Console.WriteLine($"Operacao invalida. Repita o processo");
        break;
}


