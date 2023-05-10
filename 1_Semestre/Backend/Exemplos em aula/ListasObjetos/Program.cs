// Crie uma classe Produto com as propriedades: int Código, string Nome, float Preco.
// Crie um construtor vazio.
// Crie um construtor completo.

using ListasObjetos;

List<Produto> produtos = new List<Produto>();

produtos.Add(
    new Produto(2563, "QuickSilver", 19.90f)
);

produtos.Add(
    new Produto(1025, "Tenis NAiki", 50f)
);

Produto calcaDiesel = new Produto(1526, "calça Disel Calvo klein", 15f);

produtos.Add(calcaDiesel);

Console.WriteLine($"Lista Antiga");
Console.WriteLine($"****************");

foreach (var item in produtos)
{
    Console.WriteLine($"Código: {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco:C} {produtos.IndexOf(item)}");
}

// Update

Produto produtoBuscado = produtos.Find(x => x.Codigo == 2563);

int index = produtos.IndexOf(produtoBuscado);

produtoBuscado.Preco = 199.90f;

produtos.RemoveAt(index);

produtos.Insert(index, produtoBuscado);

Console.WriteLine($"Lista Atualizada");
Console.WriteLine($"****************");

foreach (var item in produtos)
{
    Console.WriteLine($"Código: {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco:C} {produtos.IndexOf(item)}");
}

