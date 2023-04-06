// Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações.

Console.WriteLine($"Informe o nome de usuario: ");
string nome = Console.ReadLine()!;

Console.WriteLine($"O nome de usuario e {nome}");


Console.WriteLine($"Informe a senha: ");
string senha = Console.ReadLine()!;

while (senha == nome)
{
    Console.WriteLine($"Senha invalida. Insira uma senha diferente do nome de usuario.");
    senha = Console.ReadLine()!;
}


