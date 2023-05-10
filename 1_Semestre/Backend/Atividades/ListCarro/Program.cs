// Criar um projeto de console.
// Criar uma classe Carro, com marca e cor.
// Criar um construtor vazio e um completo.
// Receber dados no console para adicionar 2 objetos em uma lista.
// Exibir os dois objetos da lista no console.

using ListCarro;

List<Carro> carros = new List<Carro>();

carros.Add(
    new Carro("Ferrari", "Vermelha")
);

carros.Add(
    new Carro("Mustang", "Azul")
);

Carro primeiro = new Carro("Ferrari","Vermelha");

Carro segundo = new Carro("Mustang", "Azul");

Console.WriteLine($"Lista de carros da minha garagem");
Console.WriteLine($"********************************");

foreach (var item in carros)
{
    Console.WriteLine($"Marca: {item.Marca}, cor: {item.Cor} ");
}