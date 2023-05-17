Console.WriteLine($"Insira a senha: ");
string senha = Console.ReadLine();
// validar com bool ou com if?
if (senha == "1234")
{
    Console.WriteLine($"ACESSO PERMITIDO!");
}
else
{
    Console.WriteLine($"ACESSO NEGADO!");
}