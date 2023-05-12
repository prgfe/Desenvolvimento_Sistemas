// Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado
// produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
// A.O número de pessoas que responderam SIM.
// B.O número de pessoas que responderam NÃO;
// C.O número de mulheres que responderam SIM;
// D.A porcentagem de homens que responderam NÃO entre todos os homens analisados.

int masc = 0, fem = 0, sim = 0, nao = 0, mulheresSim = 0, homensNao = 0;

for (var i = 1; i <= 10; i++)
{
Console.WriteLine($"Pessoa {i}");

Console.WriteLine(@$"Informe seu sexo:
m - masculino;
f - feminino;
");
char sexo = char.Parse(Console.ReadLine()!.ToLower());

Console.WriteLine(@$"Gostou do produto: 
s - sim;
n - não;
");
char resposta = char.Parse(Console.ReadLine()!.ToLower());

if ((sexo == 'm') && (resposta == 's'))
{
    masc++;
    sim++;
}

else if ((sexo == 'm') && (resposta =='n'))
{
    masc++;
    nao++;
    homensNao++;
}

else if ((sexo == 'f') && (resposta == 's'))
{
    fem++;
    sim++;
    mulheresSim++;
}

else if ((sexo == 'f') && (resposta =='n'))
{
    fem++;
    nao++;
}

}

float porcentagem = (float)homensNao / (float)masc*100;

Console.WriteLine(@$"Resultado da pesquisa:
Sim: {sim}
Não: {nao}
Mulheres que gostaram do produto: {mulheresSim}
Porcentagem de homens que não gostaram do produto: {porcentagem} %
");
