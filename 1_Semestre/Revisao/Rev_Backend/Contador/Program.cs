// Faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:

// "Telefonou para a vítima?"

// "Esteve no local do crime?"

// "Mora perto da vítima?"

// "Devia para a vítima?"

// "Já trabalhou com a vítima?"

// O programa deve no final emitir uma classificação sobre a participação da pessoa no crime. Se a pessoa responder positivamente a 2 questões ela deve ser classificada como "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como “Culpado“. Caso contrário, ele será classificado como "Inocente“.

Console.WriteLine($"Telefonou para a vítima? (s/n)");
string telefone = Console.ReadLine().ToLower();

Console.WriteLine($"Esteve no local do crime? (s/n)");
string local = Console.ReadLine().ToLower();

Console.WriteLine($"Mora perto da vítima? (s/n)");
string moradia = Console.ReadLine().ToLower();

Console.WriteLine($"Devia para a vítima? (s/n)");
string devedor = Console.ReadLine().ToLower();

Console.WriteLine($"Já trabalhou com a vítima? (s/n)");
string trabalho = Console.ReadLine().ToLower();

int i = 0;

if (telefone == "s")
{
   i++; 
}
if (local == "s")
{
   i++; 
}
if (moradia == "s")
{
   i++; 
}
if (devedor == "s")
{
   i++; 
}
if (trabalho == "s")
{
   i++; 
}

if (i == 2)
{
    Console.WriteLine($"Suspeita");    
}
else if (i <= 4)
{
    Console.WriteLine($"Cúmplice");
}
else if (i == 5)
{
    Console.WriteLine($"Culpada");
}
else
{
    Console.WriteLine($"Inocente");
}