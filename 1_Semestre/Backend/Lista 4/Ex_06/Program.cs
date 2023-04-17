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

string[] nomes = new string[10];

bool nomeEncontrado = false;

for (var i = 0; i < 3; i++)
{
    Console.WriteLine($"Informe o {i + 1}º nome");
    nomes[i] = Console.ReadLine()!;    
}

Console.WriteLine($"Informe um nome a ser buscado: ");
string nomeBuscado = Console.ReadLine()!;

foreach (string nome in nomes)
{
    if (nome == nomeBuscado)
    {
        nomeEncontrado = true;
        break;
    }
}

Console.WriteLine(nomeEncontrado ? "Achei" : "Não achei");