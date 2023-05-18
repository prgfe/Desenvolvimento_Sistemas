Console.WriteLine($"Insira o número de maçãs compradas: ");
int numeroMacas = int.Parse(Console.ReadLine());

if (numeroMacas < 12)
{
    float totalCompra = numeroMacas * 0.30f;
    Console.WriteLine($"Total da compra: {totalCompra:C}");
}
else if (numeroMacas >= 12)
{
    float totalCompra = numeroMacas * 0.25f;
    Console.WriteLine($"Total da compra: {totalCompra:C}");
}