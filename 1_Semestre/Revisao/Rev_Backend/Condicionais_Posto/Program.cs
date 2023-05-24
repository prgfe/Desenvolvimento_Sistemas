Console.WriteLine($"Informe a quantidade vendida, em litros: ");
float qtde = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o tipo de combustível: ('g' - gasolina, 'a' - álcool)");
string tipo = Console.ReadLine();

float total;
float gasolina = 5.30f;
float alcool = 4.90f;
switch (tipo)
{
    case "a":
        if (qtde <= 20f)
        {
            total = qtde * alcool * 0.97f;
            Console.WriteLine($"Total a pagar {total:C}");
        }
        if (qtde > 20f)
        {
            total = qtde * alcool * 0.95f;
            Console.WriteLine($"Total a pagar {total:C}");
        }
        break;
    case "g":
        if (qtde <= 20f)
        {
            total = qtde * gasolina * 0.96f;
            Console.WriteLine($"Total a pagar {total:C}");
        }
        if (qtde > 20)
        {
            total = qtde * gasolina * 0.94f;
            Console.WriteLine($"Total a pagar {total:C}");
        }
        break;
    default:
        Console.WriteLine($"Insira opção válida.");
        break;
}
