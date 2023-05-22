string sexo, resposta;
float homem = 0;
int sim = 0;
int nao = 0;
int homemSim = 0;
float homemNao = 0;
int mulherSim = 0;
int mulherNao = 0;
for (var i = 1; i < 11; i++)
{
    Console.WriteLine($"Pessoa {i}");
    Console.WriteLine($"Informe o sexo: ('m' - masculino, 'f' - feminino");
    sexo = Console.ReadLine().ToLower();

    Console.WriteLine($"Gostou do produto? ('s' - sim, 'n' - não)");
    resposta = Console.ReadLine().ToLower();
    Console.WriteLine($"");
    if (sexo == "m" && resposta == "s")
    {
        sim++;
        homemSim++;
        homem++;
    }
    if (sexo == "m" && resposta == "n")
    {
        nao++;
        homemNao++;
        homem++;
    }
    if (sexo == "f" && resposta == "s")
    {
        sim++;
        mulherSim++;
    }
    if (sexo == "f" && resposta == "n")
    {
        nao++;
        mulherNao++;
    }
}
Console.WriteLine(@$"Pessoas que responderam 'sim': {homemSim + mulherNao}
Pessoas que responderam 'não': {homemNao + mulherNao}
Número de mulheres que responderam 'sim': {mulherSim}
Porcentagem de homens que respoderam 'não' entre os homens pesquisados: {(homemNao / homem) * 100}%  ");



