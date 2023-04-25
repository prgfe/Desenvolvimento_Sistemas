// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.

using Celular_POO;

Celular novoCelular = new Celular();

Console.WriteLine($"Digite a cor: ");
novoCelular.Cor = Console.ReadLine();

Console.WriteLine($"Digite o modelo: ");
novoCelular.Modelo = Console.ReadLine();

Console.WriteLine($"Digite o tamanho: ");
novoCelular.Tamanho = Console.ReadLine();

Console.WriteLine($"O celular está ligado? s/n ");
string ligado = Console.ReadLine();