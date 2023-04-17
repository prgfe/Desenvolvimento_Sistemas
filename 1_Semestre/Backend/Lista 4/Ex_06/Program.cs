// Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
// lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
// pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
// entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.

// Informar 1º nome
// Armazenar 1º nome
// ...
// Digitar um nome

// Buscar nome na lista

// Se corresponder ao nome, mostrar achei
// Se não corresponder ao nome, não achei

string[] lista = new string[3];
for (var i = 0; i < 3; i++)
{
    Console.WriteLine($"Informe o {i + 1}º nome");
    string nome = Console.ReadLine()!;    
}

Console.WriteLine($"Informe um nome: ");
string x = Console.ReadLine()!;


if (lista.Contains(x))
{
    Console.WriteLine($"Achei");
}
else
{
    Console.WriteLine($"Não achei");
}
