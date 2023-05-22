string senha, usuario;
do
{
    Console.WriteLine($"Insira o nome de usuário: ");
    usuario = Console.ReadLine();

    Console.WriteLine($"Insira a senha: ");
    senha = Console.ReadLine();

    if (senha == usuario)
    {
        Console.WriteLine($"Insira uma senha diferente do nome de usuário.");
    }
} while (senha == usuario);