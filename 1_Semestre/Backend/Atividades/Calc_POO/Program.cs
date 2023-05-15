using Calc_POO;

Calculadora calculo = new Calculadora();

Console.WriteLine($"Calculadora Felipino");

Console.WriteLine($"Insira o primeiro número:");
float num1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Insira o segundo número:");
float num2 = float.Parse(Console.ReadLine());

string opcao;

do
{
    Console.WriteLine(@$"Escolha a operação:
%%%%%%%%%%%%%%%%%%%%%%%%%%    
[1] Soma
[2] Subtração
[3] Multiplicação
[4] Divisão
[5] Sair
%%%%%%%%%%%%%%%%%%%%%%%%%%
");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine($"Operação de soma.");

            calculo.Somar(num1, num2);

            Console.WriteLine($"O resultado da operação é: {calculo.Somar(num1, num2)}");

            break;
        case "2":
            Console.WriteLine($"Operação de subtração.");

            calculo.Subtrair(num1, num2);

            Console.WriteLine($"O resultado da operação é: {calculo.Subtrair(num1, num2)}");

            break;
        case "3":
            Console.WriteLine($"Operação de multiplicação.");

            calculo.Multiplicar(num1, num2);

            Console.WriteLine($"O resultado da operação é: {calculo.Multiplicar(num1, num2)}");

            break;
        case "4":
            Console.WriteLine($"Operação de divisão.");

            calculo.Dividir(num1, num2);

            Console.WriteLine($"O resultado da operação é: {calculo.Dividir(num1, num2)}");

            break;
        case "5":
            Console.WriteLine($"Sair.");

            Console.WriteLine($"Desligando...");
            break;
        default:
            Console.WriteLine($"Escolha uma opção válida.");
            break;
    }

} while (opcao != "5");

