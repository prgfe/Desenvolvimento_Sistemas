using Static_ConversorMoeda;

float dolar = 4.99f;

Console.WriteLine($"Conversor de moedas");
Console.WriteLine($"");
Console.WriteLine($"Informe o valor a ser convertido: ");
float valor = float.Parse(Console.ReadLine());

Console.WriteLine(@$"

********Menu********
[1] dólar para real
[2] real para dólar
[3] sair
********************

");

string opcao = Console.ReadLine();

switch (opcao)
{
    case "1":
    Console.WriteLine($"Insira o valor em reais que deseja converter para dólares: ");
    
    Console.WriteLine($"O valor do dólar em reais é {}");
        break;
    case "2":
    Console.WriteLine($"Insira o valor em dólares que deseja converter para reais:");
    
    Console.WriteLine($"O valor do dólar em reais é {}");
        break;
    case "3":
    Console.WriteLine($"Sair");
        break;
    default:
    Console.WriteLine($"Insira uma opção válida!");
        break;
}
