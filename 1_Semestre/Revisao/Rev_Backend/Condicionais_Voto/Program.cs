Console.WriteLine($"Informe o ano de nascimento: ");
int anoNascimento = int.Parse(Console.ReadLine());

int idadeVoto = DateTime.Now.Year - anoNascimento;

if (idadeVoto >= 16)
{
    Console.WriteLine($"Vote com consciência.");
}
else
{
    Console.WriteLine($"Não completou idade de votação.");
}