string nome;
do
{
    Console.WriteLine($"Insira um nome: ");
    nome = Console.ReadLine();
} while (nome == "");
int idade;
do
{
    Console.WriteLine($"Insira a idade: ");
    idade = int.Parse(Console.ReadLine());

} while (idade < 0 && idade > 100);
float salario;
do
{
    Console.WriteLine($"Insira o salário: ");
    salario = float.Parse(Console.ReadLine());

} while (salario == 0);

string estadoCivil;
do
{
    Console.WriteLine($"Insira o estado civil: ()'s' solteiro(a), 'c' casado(a), 'd' divorciado(a), 'v' viúvo(a))");
    estadoCivil = Console.ReadLine();

} while (estadoCivil != "s" && estadoCivil != "c" && estadoCivil != "d" && estadoCivil != "v");

