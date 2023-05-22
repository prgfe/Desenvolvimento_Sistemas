int homem = 0;
int mulher = 0;
float idadeHomem = 0;
float pesoHomem = 0;
float idadeMulher = 0;
float pesoMulher = 0;

for (var i = 1; i < 4; i++)
{
    Console.WriteLine($"Pessoa {i}");

    Console.WriteLine($"Insira o sexo: ('m' - masculino,  'f' - feminino) ");
    string sexo = Console.ReadLine();

    Console.WriteLine($"Insira a idade: ");
    float idade = float.Parse(Console.ReadLine());

    Console.WriteLine($"Insira o peso: ");
    float peso = float.Parse(Console.ReadLine());

    if (sexo == "m")
    {
        homem++;
        idadeHomem += idade;
        pesoHomem += peso;
        // pesoHomem = pesoHomem + peso... long hand 
    }
    if (sexo == "f")
    {
        mulher++;
        idadeMulher += idade;
        pesoMulher += peso;
    }
}
Console.WriteLine($"Total de homens: {homem}");
Console.WriteLine($"Total de mulheres: {mulher}");
Console.WriteLine($"Média de idade dos homens: {(idadeHomem) / homem}");
Console.WriteLine($"Média de idade das mulheres: {idadeMulher / mulher}");
Console.WriteLine($"Média do peso dos homens: {pesoHomem / homem}");
Console.WriteLine($"Média do peso das mulheres: {pesoMulher / mulher}");