// Crie uma classe Aluno com as seguintes propriedades:

// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
// Também teremos os métodos: 

// VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.

// obs:
// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral
// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.

// CTRL+.= using nomedapasta.

// Acrescente o que achar necessário.

using Cadastro_POO;

Aluno novoAluno = new Aluno();

Console.WriteLine($"Digite o nome do aluno: ");
novoAluno.Nome = Console.ReadLine();

Console.WriteLine($"Digite o curso: ");
novoAluno.Curso = Console.ReadLine();

Console.WriteLine($"Digite a idade: ");
novoAluno.Idade = Console.ReadLine();

Console.WriteLine($"Digite o RG: ");
novoAluno.Rg = Console.ReadLine();

Console.WriteLine($"Digite a média final: ");
novoAluno.MediaFinal = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o valor da mensalidade: ");
novoAluno.ValorMensalidade = float.Parse(Console.ReadLine());

Console.WriteLine($"É bolsista? (s/n)");
string Bolsista = Console.ReadLine().ToLower();

novoAluno.Bolsista = Bolsista == "s" ? true : false;

// novoAluno.Bolsista = (resposta == "s"); mais avançado.

if (Bolsista == "s")
{
    novoAluno.Bolsista = true;
    Console.WriteLine($"Aluno bolsista.");
}
else
{
    novoAluno.Bolsista = false;
}

string opcao;

do
{
Console.WriteLine($"Menu");
Console.WriteLine(@$"
[1] Média do aluno
[2] Valor da mensalidade
[3] Sair
");
 opcao = Console.ReadLine();

switch (opcao)
{
    case "1":
        Console.WriteLine($"A média do aluno {novoAluno.Nome} é: {novoAluno.VerMediaFinal}");
        break;

    case "2":
        Console.WriteLine($"O valor da mensalidade é: {novoAluno.VerMensalidade}");
    break;
    case "0":
        Console.WriteLine($"Fim");
    break;    
    default:
        Console.WriteLine($"Opção inválida!");
    break;
}
} while (opcao != "0");