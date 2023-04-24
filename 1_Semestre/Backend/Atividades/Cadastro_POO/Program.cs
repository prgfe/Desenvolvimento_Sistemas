// Crie uma classe Aluno com as seguintes propriedades:

// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
// Também teremos os métodos: 

// VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.

// obs:
// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral
// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.

// Acrescente o que achar necessário.

Console.WriteLine($"Digite o nome do aluno: ");
string nome = Console.ReadLine();

Console.WriteLine($"Digite o curso: ");
string curso = Console.ReadLine();

Console.WriteLine($"Digite a idade: ");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o RG: ");
int rg = int.Parse(Console.ReadLine());

Console.WriteLine($"É bolsista? (s/n)");
string resposta = Console.ReadLine();

Console.WriteLine($"Digite a média final: ");
float media = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o calor da mensalidade: ");
float mensalidade = float.Parse(Console.ReadLine());

bool bolsista = false;
float calculo;

switch (resposta)
{
    case "s":
    bolsista = true;
    if (media >= 8)
    {
        calculo = mensalidade * 0.50f;
    }
    else if ((media >= 6) && (media < 8))
    {
        calculo = mensalidade * 0.30f;
    }
        break;
    default:
        break;
}
