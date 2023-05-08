// Crie um menu de opções de bebidas e peça para o usuário escolher uma das opções.
// A depender da opção, exiba uma mensagem se gostaria de acrescentar gelo.
// Se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo, caso contrário, a bebida é sem gelo adicional.

Console.WriteLine(@$"Escolha uma das bebidas a seguir:
[1] Suco
[2] Refrigerante
[3] Energético
[4] Café
");

string opcao = Console.ReadLine();

string adicional;

string resultado;

switch (opcao)
{
    case "1":

        Console.WriteLine($"Bebida escolhida: suco.");

        Console.WriteLine($"Gostaria de acrescentar gelo? (s/n)");

        adicional = Console.ReadLine().ToLower();

        resultado = adicional == "s" ? "Bebida com adicional de gelo." : "Bebida sem adicional de gelo.";

        Console.WriteLine($"{resultado}");
        
        break;

    case "2":

        Console.WriteLine($"Bebida escolhida: refrigerante.");
        
        Console.WriteLine($"Gostaria de acrescentar gelo? (s/n)");

        adicional = Console.ReadLine().ToLower();

        resultado = adicional == "s" ? "Bebida com adicional de gelo." : "Bebida sem adicional de gelo.";

        Console.WriteLine($"{resultado}");
        
        break;

    case "3":

            Console.WriteLine($"Bebida escolhida: energético.");

            Console.WriteLine($"Bebida escolhida sem adicional de gelo");
        
        break;

    case "4":

            Console.WriteLine($"Bebida escolhida: café.");

            Console.WriteLine($"Bebida escolhida sem adicional de gelo.");

        break;

    default:

    Console.WriteLine($"Escolha uma opção válida!");

        break;
}