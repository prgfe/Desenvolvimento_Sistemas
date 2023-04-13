// Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.

// Informe o tipo de combustível
// Informe a quantidade em litros

// Cálculo a ser pago

// Resultado

double qtde = 0d, gas = 5.30d, alc = 4.90d, tres = 0.03d, quat = 0.04d, cinc = 0.05d, seis = 0.06d, preco = 0d;

Console.WriteLine(@$"Informe o tipo de combustível:
A - Álcool;
G - Gasolina;
 ");
char tipo = char.Parse(Console.ReadLine()!.ToUpper());

Console.WriteLine($"Informe a quantidade de combustível vendida, em litros: ");
qtde = double.Parse(Console.ReadLine()!);

switch (tipo)
{
    case 'A':
    if (qtde <= 20)
    {
        preco = (qtde * alc) - (qtde * tres);
    }
    else
    {
        preco = (qtde * alc) - (qtde * cinc);
    }
        break;

    case 'G':
    if (qtde <= 20)
    {
        preco = (qtde * gas) - (qtde * quat);
    }
    else
    {
        preco = (qtde * gas) - (qtde * seis);
    }
        break;
    default:
    case ((tipo =! 'A') || (tipo =! 'G'));
        break;
}

Console.WriteLine($"O preço total é {preco} reais");





