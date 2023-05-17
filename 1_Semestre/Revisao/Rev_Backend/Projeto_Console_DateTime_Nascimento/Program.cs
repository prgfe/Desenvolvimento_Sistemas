Console.WriteLine($"Insira o ano de nascimento: ");
int anoNascimento = int.Parse(Console.ReadLine());

int idadeAnos = DateTime.Now.Year - anoNascimento;
int idadeSemanas = idadeAnos * 54;

Console.WriteLine($"A idade é: {idadeAnos} anos e {idadeSemanas} semanas");