// coca-cola
// pepsi
// fanta
// monster

// crie um menu de opcoes e peca para o usuario escolher uma das opcoes a depender da opcao, exiba uma mensagem se gostaria de acrescentar gelo, se sim, exiba uma mensagem que a bebida em questao sera com adicional de gelo, caso contrario a bebida e sem gelo adicional.

Console.ForegroundColor = ConsoleColor.Magenta;

Console.WriteLine(@$"Escolha uma bebida: 
|----------------------|
|       BEBIDAS        |
|                      |
|   (1) coca-cola      |
|   (2) pepsi          |
|   (3) fanta          |
|   (4) monster        |
|----------------------|
");
Console.ResetColor();

int escolha = int.Parse(Console.ReadLine()!);

switch (escolha)
{
    case 1:
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"Coca-cola");
    Console.ResetColor();

    if (escolha == 1)
    {                       
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Gelo adicional");
            Console.ResetColor();
    }        
        break;

    case 2:
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine($"Pepsi");
    Console.ResetColor();
    
        if (escolha == 2)
    {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Gelo adicional");
            Console.ResetColor();
    }        
        break;

    case 3:
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine($"Fanta");
    Console.ResetColor();
    
        if (escolha == 3) 
    {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Gelo adicional");
            Console.ResetColor();
    }        
        break;

    case 4:
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"Monster");
    Console.ResetColor();
    
        if (escolha == 4)
    {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Sem gelo adicional");
            Console.ResetColor();
    }        
        break;
    
    default: 
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Opção inválida, tente novamente.");
        Console.ResetColor();
        
        break;
}
