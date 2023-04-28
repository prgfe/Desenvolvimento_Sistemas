// Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo     e    escreva    se    ele    é    Equilátero,    Isósceles    ou  Escaleno. 
// Sendo    que:    
// − Triângulo    Equilátero:    possui    os    3    lados    iguais.
// − Triângulo    Isóscele:    possui    2    lados    iguais.
// − Triângulo    Escaleno:    possui    3    lados    diferentes.

Console.WriteLine($"Digite o primeiro lado (x): ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo lado (y): ");
int y = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o primeiro lado (z): ");
int z = int.Parse(Console.ReadLine());

if ((x == y) && (y == z))
{
    Console.WriteLine($"O triângulo é equilátero.");
}
else if ((x == y) || (x == z) || (y == z))
{
    Console.WriteLine($"O triângulo é isósceles");    
}
else
{
    Console.WriteLine($"O triângulo é escaleno");    
}