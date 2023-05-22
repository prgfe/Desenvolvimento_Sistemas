Console.WriteLine($"Informe o nome do produto: ");
string nome = Console.ReadLine();

Console.WriteLine($"Informe a quantidade: ");
float qtde = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o preço do produto: ");
float preco = float.Parse(Console.ReadLine());

float novoPreco = CalculoPreco(qtde, preco);
Console.WriteLine(@$"
Nome do produto: {nome}
Quantidade: {qtde}
Preço sem desconto: {preco * qtde:C}
Preço com desconto: {(novoPreco * qtde):C}
");

static float CalculoPreco(float qtde, float preco)
{
    if (qtde <= 5)
    {
        return preco -= ((preco / 100) * 2);
    }
    else if (qtde <= 10)
    {
        return preco -= ((preco / 100) * 3);
    }
    return preco -= ((preco / 100) * 5);
}