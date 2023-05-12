// Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima:
      
// A.Total de Homens;      
// B.Total de Mulheres;      
// C.Média de idade dos Homens;      
// D.Média de idade das mulheres;
// E.Peso médio dos homens;
// F.Peso médio das mulheres.

int masc = 0, fem = 0, idadeH = 0, idadeF = 0, pesoH = 0, pesoF = 0;

for (var i = 1; i < 5; i++)
{
Console.WriteLine($"Pessoa {i}");

Console.WriteLine($"Informe a idade em anos: ");
int idade = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o peso em kg (inteiro aproximado): ");
int peso = int.Parse(Console.ReadLine()!);

Console.WriteLine(@$"Informe o sexo:
m - masculino;
f - feminino;
");
char sexo = char.Parse(Console.ReadLine()!);

if (sexo == 'm')
{    
    masc++;
    idadeH+=idade;
    pesoH+=peso;    
}

else if (sexo == 'f')
{
    fem++;
    idadeF+=idade;
    pesoF+=peso;
}

}


Console.WriteLine(@$"Total de homens: {masc};
Total de mulheres: {fem};
Média de idade dos homens: {idadeH / masc};
Média de idade das mulheres: {idadeF / fem};
Média de peso dos homens: {pesoH / masc};
Média de peso das mulheres: {pesoF / fem};

");
