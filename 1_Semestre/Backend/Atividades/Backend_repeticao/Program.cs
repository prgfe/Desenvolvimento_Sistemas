//Faça um programa que leia e valide as seguintes informações:

// 1. Nome: diferente de vazio;

// 2. Idade: entre 0 e 100 anos;

// 3. Salário: maior que zero;

// 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viúvo(a)), 'd'(divorciado(a));

Console.WriteLine($"Informe um nome: ");
string nome = Console.ReadLine()!;

while (nome == "")
{
    Console.WriteLine($"Campo vazio! Escreva um nome.");
    nome = Console.ReadLine()!;
}

Console.WriteLine($"Informe a idade: ");
int idade = int.Parse(Console.ReadLine()!);

while ((idade < 0) || (idade > 100))
{
    Console.WriteLine($"Digite uma idade válida"); 
    idade = int.Parse(Console.ReadLine()!); 
}

Console.WriteLine($"Informe o salário: ");
float salario = float.Parse(Console.ReadLine()!);

while (salario <= 0)
{
    Console.WriteLine($"Informe um salário válido.");
    salario = float.Parse(Console.ReadLine()!);
}

Console.WriteLine(@$"Informe o seu estado civil:
's'(solteiro(a))
'c'(casado(a))
'v'(viúvo(a))
'd'(divorciado(a));
");
char estado = char.Parse(Console.ReadLine()!);

while ((estado != 's') && (estado != 'c') && (estado != 'v') && (estado != 'd'))
{
    Console.WriteLine($"Escolha uma das opcoes mostradas");
    estado = char.Parse(Console.ReadLine()!);
}














