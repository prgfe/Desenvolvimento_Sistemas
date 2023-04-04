// Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo     e    escreva    se    ele    é    Equilátero,    Isósceles    ou  Escaleno. 
// Sendo    que:    
// − Triângulo    Equilátero:    possui    os    3    lados    iguais.
// − Triângulo    Isósceles:    possui    2    lados    iguais.
// − Triângulo    Escaleno:    possui    3    lados    diferentes.

Console.WriteLine($"Bem-vindo ao nosso sistema de classificação de triângulos! Informe o primeiro lado do triângulo: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe o segundo lado do triângulo: ");
int y = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe o terceiro lado do triângulo: ");
int z = int.Parse(Console.ReadLine());

if ((x == y) && (y == z))
{
    Console.WriteLine($"O triângulo é equilátero");
}

else if ((x == y) && (y != z))
{
    Console.WriteLine($"O triângulo é isósceles");
}

else
{
    Console.WriteLine($"O triângulo é escaleno");  
}