Console.WriteLine($"Telefonou para a vítima? (s/n)");
string telefonou = Console.ReadLine().ToLower();

Console.WriteLine($"Esteve no local do crime? (s/n)");
string local = Console.ReadLine().ToLower();

Console.WriteLine($"Mora perto da vítima? (s/n)");
string moradia = Console.ReadLine().ToLower();

Console.WriteLine($"Devia para a vítima? (s/n)");
string divida = Console.ReadLine().ToLower();

Console.WriteLine($"Já trabalhou com a vítima? (s/n)");
string trabalhou = Console.ReadLine().ToLower();

int classificacao = 0;

if (telefonou == "s")
{
    classificacao++;
}
if (moradia == "s")
{
    classificacao++;
}
if (local == "s")
{
    classificacao++;
}
if (divida == "s")
{
    classificacao++;
}
if (trabalhou == "s")
{
    classificacao++;
}

if (classificacao == 2)
{
    Console.WriteLine($"Suspeita");
}
else if (classificacao == 3 || classificacao == 4)
{
    Console.WriteLine($"Cúmplice");
}
else if (classificacao == 5)
{
    Console.WriteLine($"Culpado");
}
else
{
    Console.WriteLine($"Inocente");
}