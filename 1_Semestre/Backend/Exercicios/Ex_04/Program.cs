﻿// Escreva     um     programa     que     verifique     a     validade     de     uma     senha     fornecida pelo     usuário. 
// A     senha     válida     é     o     número     1234. 
// Devem     ser    impressas     as    seguintes     mensagens:
// ACESSO    PERMITIDO    caso    a    senha    seja    válida.
// ACESSO    NEGADO    caso    a    senha    seja    inválida.

Console.WriteLine($"Bem-vindo ao nosso sistema de verificação de senha. Informe a senha de quatro dígitos: ");

int senha = int.Parse(Console.ReadLine());

if (senha == 1234)
{
    Console.WriteLine($"Acesso permitido");
}
else
{
    Console.WriteLine($"Acesso negado");
}