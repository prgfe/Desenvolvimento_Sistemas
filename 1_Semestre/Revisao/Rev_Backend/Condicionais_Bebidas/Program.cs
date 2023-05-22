Console.WriteLine(@$"
+----------Menu---------+
[1] Refrigerante
[2] Suco
[3] Energético
[4] Café
+-----------------------+
");
string opcao = Console.ReadLine();

switch (opcao)
{
    case "1":
        Console.WriteLine($"Gostaria de acrescentar gelo? (s/n)");
        string gelo1 = Console.ReadLine();

        if (gelo1 == "s")
        {
            Console.WriteLine($"Gelo adicionado.");
        }
        else
        {
            Console.WriteLine($"Sem gelo.");
        }
        break;
    case "2":
        Console.WriteLine($"Gostaria de acrescentar gelo? (s/n)");
        string gelo2 = Console.ReadLine();

        if (gelo2 == "s")
        {
            Console.WriteLine($"Gelo adicionado.");
        }
        else
        {
            Console.WriteLine($"Sem gelo.");
        }
        break;
    case "3":
        Console.WriteLine($"Bebida sem adicional de gelo.");
        break;
    case "4":
        Console.WriteLine($"Bebida sem adicional de gelo.");
        break;

    default:
        Console.WriteLine($"Escolha uma opção válida!");
        break;
}
