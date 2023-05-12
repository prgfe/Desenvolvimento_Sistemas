// Faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:


// "Telefonou para a vítima?"


// "Esteve no local do crime?"


// "Mora perto da vítima?"


// "Devia para a vítima?"


// "Já trabalhou com a vítima?"
// O programa deve no final emitir uma classificação sobre a participação da pessoa no crime. Se a pessoa responder positivamente a 2 questões ela deve ser classificada como "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como “Culpado“. Caso contrário, ele será classificado como "Inocente“.

Console.WriteLine($"Responda sim ou não: Telefonou para a vítima?");

string telefone = Console.ReadLine ()!;

Console.WriteLine($"Responda sim ou não: Esteve no local do crime?");

string local = Console.ReadLine ()!;

Console.WriteLine($"Responda sim ou não: Mora perto da vítima?");

string moradia = Console.ReadLine ()!;

Console.WriteLine($"Responda sim ou não: Devia para a vítima?");

string grana = Console.ReadLine ()!;

Console.WriteLine($"Responda sim ou não: Já trabalhou com a vítima?");

string trabalho = Console.ReadLine ()!;

int contador = 0;

if (telefone == "sim")
{
    contador += 1;
}

if (local == "sim")
{
    contador += 1;
}

if (moradia == "sim")
{
    contador += 1;
}

if (grana == "sim")
{
    contador += 1;
}

if (trabalho == "sim")
{
    contador += 1;
}

if (contador == 2)
{
    Console.WriteLine($"Suspeita");
}

if ((contador == 3) || (contador == 4))
{
    Console.WriteLine($"Cúmplice");
}

if (contador == 5)
{
    Console.WriteLine($"Culpado");
}

if (contador < 2)
{
    Console.WriteLine($"Inocente");
}